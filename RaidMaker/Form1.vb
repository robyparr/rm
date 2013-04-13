Public Class Form1
    ' Programmer: Wovaki
    ' Version:    1.5
    ' Date:       June 3, 2009

    Private Sub NewRaid()
        ' Start Page
        TxtRaidDelay.Clear()
        TxtRaids.Clear()

        ' Announcements
        ListAnnouncements.Items.Clear()
        ClearAnnouncements()

        ' SingleSpawns
        ListSingleSpawns.Items.Clear()
        ClearSingleSpawns()

        ' AreaSpawns
        ListAreaSpawns.Items.Clear()
        ClearAreaSpawns()
    End Sub

#Region "Clear Fields"
    Private Sub ClearAnnouncements()
        TxtAnnounceDelay.Clear()
        TxtAnnouncement.Clear()
        ComboAnnounceType.Text = Nothing
    End Sub

    Private Sub ClearSingleSpawns()
        TxtSingleDelay.Clear()
        TxtSingleMonster.Clear()
        TxtSingleX.Clear()
        TxtSingleY.Clear()
        TxtSingleZ.Clear()
    End Sub

    Private Sub ClearAreaSpawns()
        TxtAreaAmount.Clear()
        TxtAreaDelay.Clear()
        TxtAreaFromX.Clear()
        TxtAreaFromY.Clear()
        TxtAreaFromZ.Clear()
        TxtAreaMonster.Clear()
        TxtAreaToX.Clear()
        TxtAreaToY.Clear()
        TxtAreaToZ.Clear()
    End Sub
#End Region

    Private Sub GenerateRaid(ByVal Location As String)
        ' Declares XML writer.
        Dim raidMaker As New System.IO.StreamWriter(Location)
        Dim xr As New System.Xml.XmlTextWriter(raidMaker)

        ' Starts the Document
        xr.WriteStartDocument()
        xr.Formatting = Xml.Formatting.Indented
        xr.WriteComment("Created by: OT RaidMaker v1.5")
        xr.WriteStartElement("raid")


        ' Announcements
        If (ListAnnouncements.Items.Count > 0) Then
            ' Writes comment "Announcements"
            xr.WriteComment("Announcements")

            For Each Item In ListAnnouncements.Items
                ' Splits Announcements
                Dim msgArray() As String = Split(Item.ToString, ";")

                ' Writes Announcements to Document
                xr.WriteStartElement("announce")
                xr.WriteAttributeString("delay", msgArray(1))
                xr.WriteAttributeString("type", msgArray(2))
                xr.WriteAttributeString("message", msgArray(0))
                xr.WriteEndElement()
            Next
        End If

        ' SingleSpawns
        If (ListSingleSpawns.Items.Count > 0) Then
            ' Writes comment "Single Spawns"
            xr.WriteComment("Single Spawns")

            For Each Item In ListSingleSpawns.Items
                ' Splits SingleSpawn's
                Dim singleArray() As String = Split(Item.ToString, ";")

                ' Writes SingleSpawn's to Document
                xr.WriteStartElement("singlespawn")
                xr.WriteAttributeString("delay", singleArray(1))
                xr.WriteAttributeString("name", singleArray(0))
                xr.WriteAttributeString("x", singleArray(2))
                xr.WriteAttributeString("y", singleArray(3))
                xr.WriteAttributeString("z", singleArray(4))
                xr.WriteEndElement()
            Next
        End If

        ' AreaSpawns
        If (ListAreaSpawns.Items.Count > 0) Then
            ' Writes comment "Area Spawns"
            xr.WriteComment("Area Spawns")

            For Each Item In ListAreaSpawns.Items
                ' Splits AreaSpawn's
                Dim areaArray() As String = Split(Item.ToString, ";")

                xr.WriteStartElement("areaspawn")
                xr.WriteAttributeString("delay", areaArray(2))
                xr.WriteAttributeString("fromx", areaArray(3))
                xr.WriteAttributeString("fromy", areaArray(4))
                xr.WriteAttributeString("fromz", areaArray(5))
                xr.WriteAttributeString("tox", areaArray(6))
                xr.WriteAttributeString("toy", areaArray(7))
                xr.WriteAttributeString("toz", areaArray(8))
                xr.WriteStartElement("monster")
                xr.WriteAttributeString("name", areaArray(0))
                xr.WriteAttributeString("amount", areaArray(1))
                xr.WriteEndElement()
                xr.WriteEndElement()
            Next
        End If

        ' Closes document
        xr.WriteEndDocument()
        xr.Close()

        ' Gets rid of File Path
        Dim raidFileSplit() As String = Split(Location, "\")

        ' Gets the File Name (including ext.)
        Dim RaidFile As String = raidFileSplit(raidFileSplit.Length - 1)

        ' Gets the Raid Name
        Dim raidName() As String = Split(RaidFile, ".")

        ' Generates Line for Raids.XML
        Dim NewRaidInfo As String = "<raid name=" + """" + raidName(0) + """" + " file=" + """" + RaidFile _
        + """" + " interval2=" + """" + TxtRaidDelay.Text + """" + " margin=" + """" + "0" + """" + "/>"

        If (My.Settings.EditRaids = False) Then
            ' Makes visible
            TxtRaids.Visible = True
            Label20.Visible = True
            Do Until GroupBox4.Height = 100
                GroupBox4.Height += 1
            Loop

            TxtRaids.Text = NewRaidInfo
        Else
            ' Makes visible
            TxtRaids.Visible = False
            Label20.Visible = False
            Do Until GroupBox4.Height = 43
                GroupBox4.Height -= 1
            Loop

            ' Edits the raids.xml file
            EditRaidsFile(TxtRaidsLoc.Text, NewRaidInfo)
        End If
    End Sub

    Private Sub EditRaidsFile(ByVal RaidsFileLocation As String, ByVal NewRaidsInfo As String)
        ' Declares stream reader
        Dim RaidReader As New IO.StreamReader(RaidsFileLocation)

        ' FileContents holds the raids.xml contents
        ' We then read the next two lines, the xml declaration
        ' and <raids> tag into the contents variable
        Dim FileContents As String = RaidReader.ReadLine() + vbNewLine
        FileContents += RaidReader.ReadLine() + vbNewLine

        ' Adds in our newly created raid
        FileContents += NewRaidsInfo + vbNewLine

        ' Reads in the rest of the file
        FileContents += RaidReader.ReadToEnd()

        ' Closes the reader
        RaidReader.Dispose()
        RaidReader.Close()

        ' Saves the new raids.xml file
        My.Computer.FileSystem.WriteAllText(RaidsFileLocation, FileContents, False)
    End Sub

    Private Sub LoadRaid(ByVal Location As String)
        ' Clears all fields
        NewRaid()

        ' Loads raid file
        Dim root As XElement = XElement.Load(Location)

        ' Announcements
        Dim announcements = root.<announce>

        For i As Integer = 0 To announcements.Count - 1
            ListAnnouncements.Items.Add(announcements(i).@message + ";" + announcements(i).@delay + ";" + announcements(i).@type)
        Next

        ' SingleSpawns
        Dim singleSpawns = root.<singlespawn>

        For i As Integer = 0 To singleSpawns.Count - 1
            ListSingleSpawns.Items.Add(singleSpawns(i).@name + ";" + singleSpawns(i).@delay + ";" + singleSpawns(i).@x + ";" + singleSpawns(i).@y + ";" + singleSpawns(i).@z)
        Next

        ' AreaSpawns
        Dim areaSpawns = root.<areaspawn>

        Dim areaSpawnsMonster = areaSpawns.<monster>


        For i As Integer = 0 To areaSpawns.Count - 1
            ListAreaSpawns.Items.Add(areaSpawnsMonster(i).@name + ";" + areaSpawnsMonster(i).@amount + ";" + areaSpawns(i).@delay + ";" + areaSpawns(i).@fromx + ";" + areaSpawns(i).@fromy _
            + ";" + areaSpawns(i).@fromz + ";" + areaSpawns(i).@tox + ";" + areaSpawns(i).@toy + ";" + areaSpawns(i).@toz)
        Next

        MsgBox("Raid has been loaded.")
    End Sub

    Private Sub LoadOptions()
        ChkClearFields.Checked = My.Settings.ClearFields
        ChkEditRaids.Checked = My.Settings.EditRaids
        TxtRaidsLoc.Text = My.Settings.RaidsFileLoc
    End Sub

    Private Sub SaveOptions()
        My.Settings.ClearFields = ChkClearFields.Checked
        My.Settings.EditRaids = ChkEditRaids.Checked
        My.Settings.RaidsFileLoc = TxtRaidsLoc.Text

        My.Settings.Save()
    End Sub

#Region "Editing"
    Private Sub EditAnnouncements()
        ' Error message
        If (ListAnnouncements.SelectedItem = Nothing) Then
            MsgBox("You need to select an item to edit.")
            Exit Sub
        End If

        ' Fills fields
        Dim splitAnnouncement() As String = Split(ListAnnouncements.SelectedItem, ";")

        TxtAnnouncement.Text = splitAnnouncement(0)
        TxtAnnounceDelay.Text = splitAnnouncement(1)
        ComboAnnounceType.Text = splitAnnouncement(2)

        ' Changes controls
        BtnAnnounceAdd.Text = "Save"
        BtnAnnounceRemove.Enabled = False
        ListAnnouncements.Enabled = False
    End Sub

    Private Sub EditSingleSpawns()
        ' Error message
        If (ListSingleSpawns.SelectedItem = Nothing) Then
            MsgBox("You need to select an item to edit.")
            Exit Sub
        End If

        ' Fills fields
        Dim splitSingleSpawn() As String = Split(ListSingleSpawns.SelectedItem, ";")

        TxtSingleMonster.Text = splitSingleSpawn(0)
        TxtSingleDelay.Text = splitSingleSpawn(1)
        TxtSingleX.Text = splitSingleSpawn(2)
        TxtSingleY.Text = splitSingleSpawn(3)
        TxtSingleZ.Text = splitSingleSpawn(4)

        ' Changes controls
        BtnSingleAdd.Text = "Save"
        BtnSingleRemove.Enabled = False
        ListSingleSpawns.Enabled = False
    End Sub

    Private Sub EditAreaSpawns()
        ' Error message
        If (ListAreaSpawns.SelectedItem = Nothing) Then
            MsgBox("You need to select an item to edit.")
            Exit Sub
        End If

        ' Fills fields
        Dim splitAreaSpawn() As String = Split(ListAreaSpawns.SelectedItem, ";")

        TxtAreaMonster.Text = splitAreaSpawn(0)
        TxtAreaAmount.Text = splitAreaSpawn(1)
        TxtAreaDelay.Text = splitAreaSpawn(2)
        TxtAreaFromX.Text = splitAreaSpawn(3)
        TxtAreaFromY.Text = splitAreaSpawn(4)
        TxtAreaFromZ.Text = splitAreaSpawn(5)
        TxtAreaToX.Text = splitAreaSpawn(6)
        TxtAreaToY.Text = splitAreaSpawn(7)
        TxtAreaToZ.Text = splitAreaSpawn(8)

        ' Changes controls
        BtnAreaAdd.Text = "Save"
        BtnAreaRemove.Enabled = False
        ListAreaSpawns.Enabled = False
    End Sub
#End Region

#Region "Open/Close Items"
    Private Sub AnnouncementState(ByVal Open As Boolean)
        ' Checks if other items are open
        If (GroupSingle.Height > 30) Then
            SingleSpawnState(False)
        ElseIf (GroupArea.Height > 30) Then
            AreaSpawnState(False)
        End If

        ' Checks if it should open or close Announcements
        If (Open = True) Then
            ' Opens announcements
            Do Until GroupAnnounce.Height = 263
                GroupAnnounce.Height += 1

                ' Moves other items
                GroupSingle.Location = New Point(GroupSingle.Location.X, GroupSingle.Location.Y + 1)
                GroupArea.Location = New Point(GroupArea.Location.X, GroupArea.Location.Y + 1)
            Loop
        Else
            ' Closes announcements
            Do Until GroupAnnounce.Height = 30
                GroupAnnounce.Height -= 1

                ' Moves other items
                GroupSingle.Location = New Point(GroupSingle.Location.X, GroupSingle.Location.Y - 1)
                GroupArea.Location = New Point(GroupArea.Location.X, GroupArea.Location.Y - +1)
            Loop
        End If
    End Sub

    Private Sub SingleSpawnState(ByVal Open As Boolean)
        ' Checks if other items are open
        If (GroupAnnounce.Height > 30) Then
            AnnouncementState(False)
        ElseIf (GroupArea.Height > 30) Then
            AreaSpawnState(False)
        End If

        ' Checks if it should open or close single spawns
        If (Open = True) Then
            ' Opens single spawns
            Do Until GroupSingle.Height = 270
                GroupSingle.Height += 2

                ' Moves other items
                GroupArea.Location = New Point(GroupArea.Location.X, GroupArea.Location.Y + 2)
            Loop
        Else
            ' Closes single spawns
            Do Until GroupSingle.Height = 30
                GroupSingle.Height -= 2

                ' Moves other items
                GroupArea.Location = New Point(GroupArea.Location.X, GroupArea.Location.Y - 2)
            Loop
        End If
    End Sub

    Private Sub AreaSpawnState(ByVal Open As Boolean)
        ' Checks if other items are open
        If (GroupAnnounce.Height > 30) Then
            AnnouncementState(False)
        ElseIf (GroupSingle.Height > 30) Then
            SingleSpawnState(False)
        End If

        ' Checks if it should open or close area spawns
        If (Open = True) Then
            ' Opens area spawns
            Do Until GroupArea.Height = 270
                GroupArea.Height += 4
            Loop
        Else
            ' Closes area spawns
            Do Until GroupArea.Height = 30
                GroupArea.Height -= 4
            Loop
        End If
    End Sub
#End Region

    ' Controls
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadOptions()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveOptions()
    End Sub

#Region "Add/Remove Buttons"
    ' Announcements
    Private Sub BtnAnnounceAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnounceAdd.Click
        ' Error messages
        If (TxtAnnounceDelay.Text = Nothing) Or (TxtAnnouncement.Text = Nothing) Or (ComboAnnounceType.Text = Nothing) Then
            MsgBox("Some information is missing.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ' Checks if editing
        If (BtnAnnounceAdd.Text = "Add") Then
            ' Adds announcement
            ListAnnouncements.Items.Add(TxtAnnouncement.Text + ";" + TxtAnnounceDelay.Text + ";" + ComboAnnounceType.Text)

            ' Clears fields
            If (ChkClearFields.Checked = True) Then
                ClearAnnouncements()
            End If
        Else
            ' Gets item being edited
            Dim AnnounceIndex As Integer = ListAnnouncements.SelectedIndex

            ' Removes items being edited
            ListAnnouncements.Items.Remove(ListAnnouncements.SelectedItem)

            ' Replaces edited item
            ListAnnouncements.Items.Insert(AnnounceIndex, TxtAnnouncement.Text + ";" + TxtAnnounceDelay.Text + ";" + ComboAnnounceType.Text)

            ' Clears Fields
            ClearAnnouncements()

            ' Changes controls
            BtnAnnounceAdd.Text = "Add"
            BtnAnnounceRemove.Enabled = True
            ListAnnouncements.Enabled = True
        End If
    End Sub

    Private Sub BtnAnnounceRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnounceRemove.Click
        ' Error message
        If (ListAnnouncements.SelectedItem = Nothing) Then
            MsgBox("You must select an item to remove.")
            Exit Sub
        End If

        ' Removes item
        ListAnnouncements.Items.Remove(ListAnnouncements.SelectedItem)
    End Sub

    ' SingleSpawns
    Private Sub BtnSingleAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSingleAdd.Click
        ' Error messages
        If (TxtSingleDelay.Text = Nothing) Or (TxtSingleMonster.Text = Nothing) Or (TxtSingleX.Text = Nothing) Or _
        (TxtSingleY.Text = Nothing) Or (TxtSingleZ.Text = Nothing) Then

            MsgBox("Some information is missing.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If (BtnSingleAdd.Text = "Add") Then
            ' Adds SingleSpawn
            ListSingleSpawns.Items.Add(TxtSingleMonster.Text + ";" + TxtSingleDelay.Text + ";" + TxtSingleX.Text + ";" + TxtSingleY.Text + ";" + TxtSingleZ.Text)

            ' Clears fields
            If (ChkClearFields.Checked = True) Then
                ClearSingleSpawns()
            End If
        Else
            ' Gets item being edited
            Dim SingleIndex As Integer = ListSingleSpawns.SelectedIndex

            ' Removes items being edited
            ListSingleSpawns.Items.Remove(ListSingleSpawns.SelectedItem)

            ' Replaces edited item
            ListSingleSpawns.Items.Insert(SingleIndex, TxtSingleMonster.Text + ";" + TxtSingleDelay.Text + ";" + TxtSingleX.Text + ";" + TxtSingleY.Text + ";" + TxtSingleZ.Text)

            ' Clears Fields
            ClearSingleSpawns()

            ' Changes controls
            BtnSingleAdd.Text = "Add"
            BtnSingleRemove.Enabled = True
            ListSingleSpawns.Enabled = True
        End If
    End Sub

    Private Sub BtnSingleRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSingleRemove.Click
        ' Error message
        If (ListSingleSpawns.SelectedItem = Nothing) Then
            MsgBox("You must select an item to remove.")
            Exit Sub
        End If

        ' Removes item
        ListSingleSpawns.Items.Remove(ListSingleSpawns.SelectedItem)

    End Sub

    ' AreaSpawns
    Private Sub BtnAreaAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAreaAdd.Click
        ' Error messages
        If (TxtAreaAmount.Text = Nothing) Or (TxtAreaDelay.Text = Nothing) Or (TxtAreaFromX.Text = Nothing) Or _
        (TxtAreaFromY.Text = Nothing) Or (TxtAreaFromZ.Text = Nothing) Or (TxtAreaToX.Text = Nothing) _
        Or (TxtAreaToY.Text = Nothing) Or (TxtAreaToZ.Text = Nothing) Then

            MsgBox("Some information is missing.", MsgBoxStyle.Critical)
            Exit Sub
        End If


        Dim AreaSpawn As String = TxtAreaMonster.Text + ";" + TxtAreaAmount.Text + ";" + TxtAreaDelay.Text + ";" _
        + TxtAreaFromX.Text + ";" + TxtAreaFromY.Text + ";" + TxtAreaFromZ.Text + ";" + TxtAreaToX.Text + ";" _
        + TxtAreaToY.Text + ";" + TxtAreaToZ.Text

        If (BtnAreaAdd.Text = "Add") Then
            ' Adds AreaSpawn
            ListAreaSpawns.Items.Add(AreaSpawn)

            ' Clears fields
            If (ChkClearFields.Checked = True) Then
                ClearAreaSpawns()
            End If
        Else
            ' Gets item being edited
            Dim AreaIndex As Integer = ListAreaSpawns.SelectedIndex

            ' Removes items being edited
            ListAreaSpawns.Items.Remove(ListAreaSpawns.SelectedItem)

            ' Replaces edited item
            ListAreaSpawns.Items.Insert(AreaIndex, AreaSpawn)

            ' Clears Fields
            ClearAreaSpawns()

            ' Changes controls
            BtnAreaAdd.Text = "Add"
            BtnAreaRemove.Enabled = True
            ListAreaSpawns.Enabled = True
        End If
    End Sub

    Private Sub BtnAreaRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAreaRemove.Click
        ' Error message
        If (ListAreaSpawns.SelectedItem = Nothing) Then
            MsgBox("You must select an item to remove.")
            Exit Sub
        End If

        ' Removes item
        ListAreaSpawns.Items.Remove(ListAreaSpawns.SelectedItem)

    End Sub
#End Region

    Private Sub BtnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveAs.Click
        ' Error messages
        If (TxtRaidDelay.Text = Nothing) Then
            MsgBox("Fill in the raid delay in the start page.")
            Exit Sub
        ElseIf (My.Settings.EditRaids = True) And (My.Computer.FileSystem.FileExists(My.Settings.RaidsFileLoc) = False) Then
            MsgBox("Please select your raids.xml file in the options.")
            Exit Sub
        End If

        ' Saves file
        Dim sfd As New SaveFileDialog

        sfd.Title = "Save Raid File."

        sfd.Filter = "XML Files (*.xml)|*.xml"

        If (sfd.ShowDialog And sfd.FileName.Length > 0) Then
            GenerateRaid(sfd.FileName)
        End If
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        If (MsgBox("Are you sure you want to start a new raid?" + vbNewLine + "You will lose any unsaved raids.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            NewRaid()
        End If
    End Sub

    Private Sub BtnLoadRaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadRaid.Click
        ' Confirmation
        If (MsgBox("Are you sure you want to load a raid?" + vbNewLine + "Unsaved data will be lost." _
                   , MsgBoxStyle.YesNo) = MsgBoxResult.No) Then
            Exit Sub
        End If

        Dim ofd As New OpenFileDialog()

        ofd.Title = "Open Raid"
        ofd.Filter = "XML Files (*.xml)|*.xml"

        If (ofd.ShowDialog() = DialogResult.OK) Then
            LoadRaid(ofd.FileName)
        End If
    End Sub

    Private Sub BtnAnnounce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnounce.Click
        If (GroupAnnounce.Height = 30) Then
            AnnouncementState(True)
        Else
            AnnouncementState(False)
        End If
    End Sub

    Private Sub BtnSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSingle.Click
        If (GroupSingle.Height = 30) Then
            SingleSpawnState(True)
        Else
            SingleSpawnState(False)
        End If
    End Sub

    Private Sub BtnArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArea.Click
        If (GroupArea.Height = 30) Then
            AreaSpawnState(True)
        Else
            AreaSpawnState(False)
        End If
    End Sub

    Private Sub ChkEditRaids_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEditRaids.CheckedChanged
        If (ChkEditRaids.Checked) Then
            TxtRaidsLoc.Enabled = True
            BtnBrowseRaidsLoc.Enabled = True
        Else
            TxtRaidsLoc.Enabled = False
            BtnBrowseRaidsLoc.Enabled = False
        End If
    End Sub

    Private Sub BtnBrowseRaidsLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowseRaidsLoc.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select raids.xml file"
        ofd.Filter = "XML Files (*.xml)|*.xml"

        If (ofd.ShowDialog() = DialogResult.OK) Then
            TxtRaidsLoc.Text = ofd.FileName
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim List As String = ContextList.SourceControl.Name
        Select Case List
            Case ListAnnouncements.Name
                EditAnnouncements()
            Case ListSingleSpawns.Name
                EditSingleSpawns()
            Case ListAreaSpawns.Name
                EditAreaSpawns()
        End Select
    End Sub

    Private Sub BtnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbout.Click
        FrmAbout.ShowDialog()
    End Sub

    Private Sub TxtRaids_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRaids.Click
        TxtRaids.SelectAll()
    End Sub
End Class
