Imports System.ComponentModel
Imports System.Reflection

''' <summary>
''' Provides a sorted view into an existing IList (collection).
''' </summary>
Public Class SortedView
  Implements IList
  Implements IBindingList

#Region " ListItem class "

  Private Class ListItem
    Implements IComparable

    Public Key As Object
    Public Item As Object

    Public Sub New(ByVal key As Object, ByVal item As Object)
      Me.Key = key
      Me.Item = item
    End Sub

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo

      Dim target As Object = DirectCast(obj, ListItem).Key

      If TypeOf Key Is IComparable Then
        Return DirectCast(Key, IComparable).CompareTo(target)

      Else
        If Key.Equals(target) Then
          Return 0

        Else
          Return Key.ToString.CompareTo(target.ToString)
        End If
      End If

    End Function

    Public Overrides Function ToString() As String
      Return Key.ToString
    End Function

  End Class

#End Region

#Region " Sorted enumerator "

  Private Class SortedEnumerator
    Implements IEnumerator

    Private mSortIndex As ArrayList
    Private mSortOrder As ListSortDirection
    Private index As Integer

    Public Sub New(ByVal sortIndex As ArrayList, ByVal direction As ListSortDirection)
      mSortIndex = sortIndex
      mSortOrder = direction
      Reset()
    End Sub

    Public ReadOnly Property Current() As Object Implements System.Collections.IEnumerator.Current
      Get
        Return DirectCast(mSortIndex(index), ListItem).Item
      End Get
    End Property

    Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
      If mSortOrder = ListSortDirection.Ascending Then
        If index < mSortIndex.Count - 1 Then
          index += 1
          Return True

        Else
          Return False
        End If

      Else
        If index > 0 Then
          index -= 1
          Return True

        Else
          Return False
        End If
      End If

    End Function

    Public Sub Reset() Implements System.Collections.IEnumerator.Reset
      If mSortOrder = ListSortDirection.Ascending Then
        index = -1
      Else
        index = mSortIndex.Count
      End If
    End Sub

  End Class

#End Region

  Private mList As IList
  Private mSupportsBinding As Boolean
  Private mBindingList As IBindingList
  Private mSorted As Boolean = False
  Private mSortBy As PropertyDescriptor
  Private mSortOrder As ListSortDirection = ListSortDirection.Ascending
  Private mSortIndex As New ArrayList

  Public ReadOnly Property BindindList() As IBindingList
    Get
      Return mBindingList
    End Get
  End Property

  ''' <summary>
  ''' Creates a new view based on the provided IList object.
  ''' </summary>
  ''' <param name="list">The IList (collection) containing the data.</param>
  Public Sub New(ByVal list As IList)

    mList = list

    If TypeOf mList Is IBindingList Then
      mSupportsBinding = True
      mBindingList = DirectCast(mList, IBindingList)
      AddHandler mBindingList.ListChanged, AddressOf SourceChanged
    End If

  End Sub

  Private Sub SourceChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)

    If mSorted Then
      If e.ListChangedType = ListChangedType.ItemAdded Then
        If mSortOrder = ListSortDirection.Ascending Then
          mSortIndex.Add(New ListItem(mSortBy.GetValue(mList(e.NewIndex)), mList(e.NewIndex)))

        Else
          mSortIndex.Insert(0, New ListItem(mSortBy.GetValue(mList(e.NewIndex)), mList(e.NewIndex)))
        End If
        RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.ItemAdded, mSortIndex.Count - 1))

      Else
        DoSort()
      End If

    Else
      RaiseEvent ListChanged(Me, e)
    End If

  End Sub

#Region " Sort/Unsort "

  Private Sub DoSort()

    mSortIndex.Clear()

    If mSortBy Is Nothing Then
      For Each obj As Object In mList
        mSortIndex.Add(New ListItem(obj, obj))
      Next

    Else
      For Each obj As Object In mList
        mSortIndex.Add(New ListItem(mSortBy.GetValue(obj), obj))
      Next
    End If

    mSortIndex.Sort()
    mSorted = True

    RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, 0))

  End Sub

  Private Sub UndoSort()

    mSortIndex.Clear()
    mSortBy = Nothing
    mSortOrder = ListSortDirection.Ascending
    mSorted = False

    RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, 0))

  End Sub

#End Region

#Region " IList "

  ''' <summary>
  ''' Copies the underlying data to an array.
  ''' </summary>
  ''' <param name="array">Array to hold the data.</param>
  ''' <param name="index">Index in the array to start the copy.</param>
  Public Sub CopyTo(ByVal array As System.Array, ByVal index As Integer) Implements System.Collections.ICollection.CopyTo

    mList.CopyTo(array, index)

  End Sub

  ''' <summary>
  ''' Returns the number of items in the collection.
  ''' </summary>
  Public ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
    Get
      Return mList.Count
    End Get
  End Property

  ''' <summary>
  ''' Returns True if the underlying IList object is synchronized.
  ''' </summary>
  Public ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
    Get
      Return mList.IsSynchronized
    End Get
  End Property

  ''' <summary>
  ''' Returns the SyncRoot object for the underling IList object.
  ''' </summary>
  Public ReadOnly Property SyncRoot() As Object Implements System.Collections.ICollection.SyncRoot
    Get
      Return mList.SyncRoot
    End Get
  End Property

  ''' <summary>
  ''' Returns the enumerator for the list.
  ''' </summary>
  ''' <remarks>
  ''' If the view is sorted, the enumerator provides a sorted
  ''' view of the data. If the view is not sorted, the enumerator
  ''' from the underlying IList object is used.
  ''' </remarks>
  Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
    If IsSorted Then
      Return New SortedEnumerator(mSortIndex, mSortOrder)

    Else
      Return mList.GetEnumerator
    End If
  End Function

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Function Add(ByVal value As Object) As Integer Implements System.Collections.IList.Add
    mList.Add(value)
    Return 1
  End Function

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Sub Clear() Implements System.Collections.IList.Clear
    mList.Clear()
  End Sub

  ''' <summary>
  ''' Returns True if the list contains the specified value.
  ''' </summary>
  Public Function Contains(ByVal value As Object) As Boolean Implements System.Collections.IList.Contains
    Return mList.Contains(value)
  End Function

  ''' <summary>
  ''' Returns the index of the specified value.
  ''' </summary>
  ''' <remarks>
  ''' If the view is sorted then the index is the index 
  ''' within the sorted list, not the underlying IList object.
  ''' </remarks>
  Public Function IndexOf(ByVal value As Object) As Integer Implements System.Collections.IList.IndexOf
    If mSorted Then
      Dim index As Integer
      For Each item As ListItem In mSortIndex
        If item.Item.Equals(value) Then
          Return index
        End If
        index += 1
      Next
      ' didn't find it...
      Return -1

    Else
      Return mList.IndexOf(value)
    End If
  End Function

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements System.Collections.IList.Insert
    mList.Insert(index, value)
  End Sub

  ''' <summary>
  ''' Returns True if the underling IList object is fixed size.
  ''' </summary>
  Public ReadOnly Property IsFixedSize() As Boolean Implements System.Collections.IList.IsFixedSize
    Get
      Return mList.IsFixedSize
    End Get
  End Property

  ''' <summary>
  ''' Returns True. The view is always read only.
  ''' </summary>
  Public ReadOnly Property IsReadOnly() As Boolean Implements System.Collections.IList.IsReadOnly
    Get
      Return True
    End Get
  End Property

  ''' <summary>
  ''' Returns the item at the specified index. Does NOT allow setting a new
  ''' value.
  ''' </summary>
  ''' <remarks>
  ''' <para>
  ''' If the list is sorted, this returns the items in the appropriate sorted
  ''' order. Otherwise the order will match that of the underlying IList object.
  ''' </para><para>
  ''' Attempting to set the value will result in an exception. To set a value,
  ''' set it in the underling IList object.
  ''' </para>
  ''' </remarks>
  ''' <param name="index">The index of the item to return.</param>
  ''' <returns>The item at the specified index.</returns>
  Default Public Property Item(ByVal index As Integer) As Object Implements System.Collections.IList.Item
    Get
      If mSorted Then
        Return GetSortedItem(index)

      Else
        Return mList.Item(index)
      End If
    End Get
    Set(ByVal Value As Object)
      If mSorted Then
        Dim pos As Integer = mList.IndexOf(GetSortedItem(index))
        mList.Item(pos) = Value
        If Not mSupportsBinding Then DoSort()

      Else
        mList.Item(index) = Value
      End If
    End Set
  End Property

  ''' <summary>
  ''' Returns the appropriate item for an index
  ''' based on the current sort.
  ''' </summary>
  Private Function GetSortedItem(ByVal index As Integer) As Object

    If mSortOrder = ListSortDirection.Ascending Then
      Return DirectCast(mSortIndex(index), ListItem).Item

    Else
      Return DirectCast(mSortIndex(mSortIndex.Count - 1 - index), ListItem).Item
    End If

  End Function

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Sub Remove(ByVal value As Object) Implements System.Collections.IList.Remove
    mList.Remove(value)
  End Sub

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Sub RemoveAt(ByVal index As Integer) Implements System.Collections.IList.RemoveAt
    If mSorted Then
      Dim pos As Integer = mList.IndexOf(GetSortedItem(index))
      mList.RemoveAt(pos)

    Else
      mList.RemoveAt(index)
    End If
  End Sub

#End Region

#Region " IBindingList "

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Sub AddIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements System.ComponentModel.IBindingList.AddIndex
    If mSupportsBinding Then
      mBindingList.AddIndex([property])
    End If
  End Sub

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Function AddNew() As Object Implements System.ComponentModel.IBindingList.AddNew
    If mSupportsBinding Then
      Return mBindingList.AddNew
    Else
      Return Nothing
    End If
  End Function

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public ReadOnly Property AllowEdit() As Boolean Implements System.ComponentModel.IBindingList.AllowEdit
    Get
      If mSupportsBinding Then
        Return mBindingList.AllowEdit

      Else
        Return False
      End If
    End Get
  End Property

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public ReadOnly Property AllowNew() As Boolean Implements System.ComponentModel.IBindingList.AllowNew
    Get
      If mSupportsBinding Then
        Return mBindingList.AllowNew

      Else
        Return False
      End If
    End Get
  End Property

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public ReadOnly Property AllowRemove() As Boolean Implements System.ComponentModel.IBindingList.AllowRemove
    Get
      If mSupportsBinding Then
        Return mBindingList.AllowRemove

      Else
        Return False
      End If
    End Get
  End Property

  ''' <summary>
  ''' Applies a sort to the view.
  ''' </summary>
  ''' <param name="property">The text name of the property on which to sort.</param>
  ''' <param name="direction">The direction to sort the data.</param>
  Public Sub ApplySort(ByVal [property] As String, ByVal direction As System.ComponentModel.ListSortDirection)

    Dim itemType As Type = Nothing

    If Len([property]) > 0 Then
      ' get default property
      Dim t As Type = DirectCast(mList, Object).GetType
      Dim defs() As MemberInfo = t.GetDefaultMembers
      For Each member As MemberInfo In defs
        If member.MemberType = MemberTypes.Property Then
          ' there is a default property so find its return type
          itemType = CType(member, PropertyInfo).GetGetMethod.ReturnType
          Exit For
        End If
      Next

      If itemType Is Nothing Then
        ' we didn't get the type from the default property
        ' so we must get it from the first item in the list
        If mList.Count > 0 Then
          itemType = mList.Item(0).GetType

        Else
          Throw New Exception("Can not determine collection item type")
        End If
      End If

      Dim props As PropertyDescriptorCollection
      props = TypeDescriptor.GetProperties(itemType)
      For Each prop As PropertyDescriptor In props
        If prop.Name = [property] Then
          mSortBy = prop
          Exit For
        End If
      Next
    End If

    ApplySort(mSortBy, direction)

  End Sub

  ''' <summary>
  ''' Applies a sort to the view.
  ''' </summary>
  ''' <param name="property">A PropertyDescriptor for the property on which to sort.</param>
  ''' <param name="direction">The direction to sort the data.</param>
  Public Sub ApplySort(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection) Implements System.ComponentModel.IBindingList.ApplySort
    mSortBy = [property]
    mSortOrder = direction
    DoSort()
  End Sub

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Function Find(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal key As Object) As Integer Implements System.ComponentModel.IBindingList.Find
    If mSupportsBinding Then
      mBindingList.Find([property], key)
    End If
    Return 1
  End Function

  ''' <summary>
  ''' Returns True if the view is currently sorted.
  ''' </summary>
  Public ReadOnly Property IsSorted() As Boolean Implements System.ComponentModel.IBindingList.IsSorted
    Get
      Return mSorted
    End Get
  End Property

  ''' <summary>
  ''' Raised to indicate that the list's data has changed.
  ''' </summary>
  ''' <remarks>
  ''' This event is raised if the underling IList object's data changes
  ''' (assuming the underling IList also implements the IBindingList
  ''' interface). It is also raised if the sort property or direction
  ''' is changed to indicate that the view's data has changed.
  ''' </remarks>
  Public Event ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Implements System.ComponentModel.IBindingList.ListChanged

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public Sub RemoveIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements System.ComponentModel.IBindingList.RemoveIndex
    If mSupportsBinding Then
      mBindingList.RemoveIndex([property])
    End If
  End Sub

  ''' <summary>
  ''' Removes any sort currently applied to the view.
  ''' </summary>
  Public Sub RemoveSort() Implements System.ComponentModel.IBindingList.RemoveSort
    UndoSort()
  End Sub

  ''' <summary>
  ''' Returns the direction of the current sort.
  ''' </summary>
  Public ReadOnly Property SortDirection() As System.ComponentModel.ListSortDirection Implements System.ComponentModel.IBindingList.SortDirection
    Get
      Return mSortOrder
    End Get
  End Property

  ''' <summary>
  ''' Returns the PropertyDescriptor of the current sort.
  ''' </summary>
  Public ReadOnly Property SortProperty() As System.ComponentModel.PropertyDescriptor Implements System.ComponentModel.IBindingList.SortProperty
    Get
      Return mSortBy
    End Get
  End Property

  ''' <summary>
  ''' Returns True since this object does raise the
  ''' ListChanged event.
  ''' </summary>
  Public ReadOnly Property SupportsChangeNotification() As Boolean Implements System.ComponentModel.IBindingList.SupportsChangeNotification
    Get
      Return True
    End Get
  End Property

  ''' <summary>
  ''' Implemented by IList source object.
  ''' </summary>
  Public ReadOnly Property SupportsSearching() As Boolean Implements System.ComponentModel.IBindingList.SupportsSearching
    Get
      If mSupportsBinding Then
        Return mBindingList.SupportsSearching

      Else
        Return False
      End If
    End Get
  End Property

  ''' <summary>
  ''' Returns True. Sorting is supported.
  ''' </summary>
  Public ReadOnly Property SupportsSorting() As Boolean Implements System.ComponentModel.IBindingList.SupportsSorting
    Get
      Return True
    End Get
  End Property

#End Region

End Class
