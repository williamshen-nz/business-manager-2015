﻿Imports System.Data.OleDb
Imports Odin.ListviewSort

Public Class Business_Expense_Application___Overview
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.dbLocation)
    Private m_SortingColumn As ColumnHeader

    Private Sub Business_Expense_Application___Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populates the listviews and focuses on the form
        populateListViewApproved()
        populateListViewPending()
        PictureBox.Select()
    End Sub

    Public Sub populateListViewPending()
        'Clears and enables the listview
        lstViewPending.Items.Clear()
        lstViewPending.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From BEA WHERE Approved = False ORDER BY TrackingNumber", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("TrackingNumber").ToString)
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("ItemDescription").ToString)
            newitem.SubItems.Add(dr.Item("Quantity").ToString)
            newitem.SubItems.Add(dr.Item("TotalPrice"))
            lstViewPending.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
    End Sub

    Public Sub populateListViewApproved()
        'Clears and enables the listview
        lstViewApproved.Items.Clear()
        lstViewApproved.Enabled = True
        'Opens the connection and declares a new OleDbCommand and Reader
        connection.Open()
        Dim cmd As New OleDbCommand("SELECT * From BEA WHERE Approved = True ORDER BY TrackingNumber", connection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        'Loops the Accounts table of the database and adds each record to a new ListViewItem
        Do While dr.Read()
            Dim newitem As New ListViewItem(dr.Item("TrackingNumber").ToString)
            newitem.SubItems.Add(dr.Item("FullName").ToString)
            newitem.SubItems.Add(dr.Item("ItemDescription").ToString)
            newitem.SubItems.Add(dr.Item("Quantity").ToString)
            newitem.SubItems.Add(dr.Item("TotalPrice"))
            lstViewApproved.Items.Add(newitem)
        Loop
        'Closes the connection
        connection.Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'Opens the form for a new business expense application
        Business_Expensive_Application___New.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Checks that either of the listviews has an item selected
        If lstViewPending.SelectedItems.Count > 0 Or lstViewApproved.SelectedItems.Count > 0 Then
            'Displays a MsgBox asking user to confirm to delete the record
            Dim Response = MsgBox("Are you sure you want to delete this Business Expense Application?", MsgBoxStyle.YesNo,
                                  "Delete Business Expense Application")
            If Response = MsgBoxResult.Yes Then
                'If response is yes then checks if an item is selected in the 'pending' listview or not
                If lstViewPending.SelectedItems.Count > 0 Then
                    'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                    Dim pending As String = lstViewPending.SelectedItems(0).Text
                    Dim cmd As New OleDbCommand("DELETE FROM BEA WHERE TrackingNumber = '" & pending & "'", connection)
                    'Opens connection, executes the command and closes the connection
                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    'Repopulates the listview
                    populateListViewPending()
                    'Updates label to show status
                    lblDataStatus.Text = "Record successfully deleted."
                    lblDataStatus.Visible = True
                    'Checks if selected item is in 'completed' listview
                ElseIf lstViewApproved.SelectedItems.Count > 0 Then
                    'Declares a new OleDbCommand which deletes the record which contains the text from the listview item
                    Dim approved As String = lstViewApproved.SelectedItems(0).Text
                    Dim cmd As New OleDbCommand("DELETE FROM BEA WHERE TrackingNumber = '" & approved & "'", connection)
                    'Opens connection, executes the command and closes the connection
                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    'Repopulates the listview
                    populateListViewApproved()
                    'Updates label to show status
                    lblDataStatus.Text = "Record successfully deleted."
                    lblDataStatus.Visible = True
                End If
            End If
            'If no item is selected then output error
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Checks if an item is selected in either listview or not
        If lstViewPending.SelectedItems.Count > 0 Then
            'Passes value of ID to Edit form and opens it
            Dim TrackingNumber As String = lstViewPending.SelectedItems(0).Text
            Business_Expense_Applications___View_and_Edit.lblTracking.Text = TrackingNumber
            Business_Expense_Applications___View_and_Edit.ShowDialog()
        ElseIf lstViewApproved.SelectedItems.Count > 0 Then
            'Passes value of ID to Edit form and opens it
            Dim TrackingNumber As String = lstViewApproved.SelectedItems(0).Text
            Business_Expense_Applications___View_and_Edit.lblTracking.Text = TrackingNumber
            Business_Expense_Applications___View_and_Edit.ShowDialog()
            'If neither listviews has an item selected then output error
        Else : MsgBox("Please select a record from the table.")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Opens SearchBox form and passes appropriate function name
        SearchBox.lblFunction.Text = "BEA"
        SearchBox.ShowDialog()
    End Sub

    Private Sub Business_Expense_Application___Overview_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Opens Main Menu form upon closing of the overview form
        MainMenu.Show()
    End Sub

    Private Sub lstViewPending_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstViewPending.ColumnClick
        'Get the new sorting column to be sorted
        Dim new_sorting_column As ColumnHeader = lstViewPending.Columns(e.Column)
        'Find out the sorting order
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            'Sort column by ascending order
            sort_order = SortOrder.Ascending
        Else
            'Checks if sorting column is the same one
            If new_sorting_column.Equals(m_SortingColumn) Then
                'If it is the same column then the sorting order is switched around
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                'Sort by ascending value
                sort_order = SortOrder.Ascending
            End If
            'Removes the old sort column indicator
            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If
        'Displays the new sorting column indicator
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If
        'Creates the comparer and sorts the listview accordingly
        lstViewPending.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        lstViewPending.Sort()
    End Sub

    Private Sub lstViewApproved_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstViewApproved.ColumnClick
        'Get the new sorting column to be sorted
        Dim new_sorting_column As ColumnHeader = lstViewApproved.Columns(e.Column)
        'Find out the sorting order
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            'Sort column by ascending order
            sort_order = SortOrder.Ascending
        Else
            'Checks if sorting column is the same one
            If new_sorting_column.Equals(m_SortingColumn) Then
                'If it is the same column then the sorting order is switched around
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                'Sort by ascending value
                sort_order = SortOrder.Ascending
            End If
            'Removes the old sort column indicator
            m_SortingColumn.Text = m_SortingColumn.Text.Substring(2)
        End If
        'Displays the new sorting column indicator
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If
        'Creates the comparer and sorts the listview accordingly
        lstViewApproved.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        lstViewApproved.Sort()
    End Sub
End Class