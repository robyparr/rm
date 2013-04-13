<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtRaidsLoc = New System.Windows.Forms.TextBox
        Me.BtnBrowseRaidsLoc = New System.Windows.Forms.Button
        Me.ChkEditRaids = New System.Windows.Forms.CheckBox
        Me.ChkClearFields = New System.Windows.Forms.CheckBox
        Me.BtnLoadRaid = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtRaids = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtRaidDelay = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.BtnAbout = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnSaveAs = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupSingle = New System.Windows.Forms.GroupBox
        Me.BtnSingle = New System.Windows.Forms.Button
        Me.BtnSingleRemove = New System.Windows.Forms.Button
        Me.BtnSingleAdd = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtSingleZ = New System.Windows.Forms.TextBox
        Me.TxtSingleY = New System.Windows.Forms.TextBox
        Me.TxtSingleX = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtSingleDelay = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtSingleMonster = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ListSingleSpawns = New System.Windows.Forms.ListBox
        Me.ContextList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupAnnounce = New System.Windows.Forms.GroupBox
        Me.BtnAnnounce = New System.Windows.Forms.Button
        Me.BtnAnnounceRemove = New System.Windows.Forms.Button
        Me.BtnAnnounceAdd = New System.Windows.Forms.Button
        Me.ComboAnnounceType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtAnnouncement = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtAnnounceDelay = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListAnnouncements = New System.Windows.Forms.ListBox
        Me.GroupArea = New System.Windows.Forms.GroupBox
        Me.BtnArea = New System.Windows.Forms.Button
        Me.BtnAreaRemove = New System.Windows.Forms.Button
        Me.BtnAreaAdd = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtAreaToZ = New System.Windows.Forms.TextBox
        Me.TxtAreaToY = New System.Windows.Forms.TextBox
        Me.TxtAreaToX = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtAreaFromZ = New System.Windows.Forms.TextBox
        Me.TxtAreaFromY = New System.Windows.Forms.TextBox
        Me.TxtAreaFromX = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtAreaAmount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtAreaDelay = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtAreaMonster = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ListAreaSpawns = New System.Windows.Forms.ListBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupSingle.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ContextList.SuspendLayout()
        Me.GroupAnnounce.SuspendLayout()
        Me.GroupArea.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(330, 382)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.BtnLoadRaid)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.BtnAbout)
        Me.TabPage4.Controls.Add(Me.BtnNew)
        Me.TabPage4.Controls.Add(Me.BtnSaveAs)
        Me.TabPage4.Controls.Add(Me.RichTextBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(322, 356)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Start"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtRaidsLoc)
        Me.GroupBox1.Controls.Add(Me.BtnBrowseRaidsLoc)
        Me.GroupBox1.Controls.Add(Me.ChkEditRaids)
        Me.GroupBox1.Controls.Add(Me.ChkClearFields)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 92)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'TxtRaidsLoc
        '
        Me.TxtRaidsLoc.Enabled = False
        Me.TxtRaidsLoc.Location = New System.Drawing.Point(24, 61)
        Me.TxtRaidsLoc.Name = "TxtRaidsLoc"
        Me.TxtRaidsLoc.Size = New System.Drawing.Size(197, 20)
        Me.TxtRaidsLoc.TabIndex = 4
        '
        'BtnBrowseRaidsLoc
        '
        Me.BtnBrowseRaidsLoc.Enabled = False
        Me.BtnBrowseRaidsLoc.Location = New System.Drawing.Point(227, 60)
        Me.BtnBrowseRaidsLoc.Name = "BtnBrowseRaidsLoc"
        Me.BtnBrowseRaidsLoc.Size = New System.Drawing.Size(27, 23)
        Me.BtnBrowseRaidsLoc.TabIndex = 3
        Me.BtnBrowseRaidsLoc.Text = "..."
        Me.BtnBrowseRaidsLoc.UseVisualStyleBackColor = True
        '
        'ChkEditRaids
        '
        Me.ChkEditRaids.AutoSize = True
        Me.ChkEditRaids.Location = New System.Drawing.Point(7, 44)
        Me.ChkEditRaids.Name = "ChkEditRaids"
        Me.ChkEditRaids.Size = New System.Drawing.Size(170, 17)
        Me.ChkEditRaids.TabIndex = 1
        Me.ChkEditRaids.Text = "Automatically edit raids.xml file."
        Me.ToolTip1.SetToolTip(Me.ChkEditRaids, "OT RaidMaker will automatically add required info to your raids.xml file.")
        Me.ChkEditRaids.UseVisualStyleBackColor = True
        '
        'ChkClearFields
        '
        Me.ChkClearFields.AutoSize = True
        Me.ChkClearFields.Location = New System.Drawing.Point(7, 20)
        Me.ChkClearFields.Name = "ChkClearFields"
        Me.ChkClearFields.Size = New System.Drawing.Size(117, 17)
        Me.ChkClearFields.TabIndex = 0
        Me.ChkClearFields.Text = "Clear Fields on Add"
        Me.ToolTip1.SetToolTip(Me.ChkClearFields, "All fields will clear when you click the 'Add' button.")
        Me.ChkClearFields.UseVisualStyleBackColor = True
        '
        'BtnLoadRaid
        '
        Me.BtnLoadRaid.Location = New System.Drawing.Point(6, 325)
        Me.BtnLoadRaid.Name = "BtnLoadRaid"
        Me.BtnLoadRaid.Size = New System.Drawing.Size(99, 23)
        Me.BtnLoadRaid.TabIndex = 6
        Me.BtnLoadRaid.Text = "Load Raid"
        Me.BtnLoadRaid.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.TxtRaids)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.TxtRaidDelay)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 95)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(308, 43)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Raids.xml"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Add to raids.xml file:"
        Me.Label20.Visible = False
        '
        'TxtRaids
        '
        Me.TxtRaids.Location = New System.Drawing.Point(10, 74)
        Me.TxtRaids.Name = "TxtRaids"
        Me.TxtRaids.Size = New System.Drawing.Size(292, 20)
        Me.TxtRaids.TabIndex = 3
        Me.TxtRaids.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(185, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "minute(s)."
        '
        'TxtRaidDelay
        '
        Me.TxtRaidDelay.Location = New System.Drawing.Point(130, 16)
        Me.TxtRaidDelay.Name = "TxtRaidDelay"
        Me.TxtRaidDelay.Size = New System.Drawing.Size(48, 20)
        Me.TxtRaidDelay.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Raid will execute every"
        '
        'BtnAbout
        '
        Me.BtnAbout.Location = New System.Drawing.Point(215, 325)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(99, 23)
        Me.BtnAbout.TabIndex = 3
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(215, 297)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(99, 23)
        Me.BtnNew.TabIndex = 2
        Me.BtnNew.Text = "New Raid"
        Me.ToolTip1.SetToolTip(Me.BtnNew, "Clears all information to create a new raid.")
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnSaveAs
        '
        Me.BtnSaveAs.Location = New System.Drawing.Point(6, 297)
        Me.BtnSaveAs.Name = "BtnSaveAs"
        Me.BtnSaveAs.Size = New System.Drawing.Size(99, 23)
        Me.BtnSaveAs.TabIndex = 1
        Me.BtnSaveAs.Text = "Save Raid"
        Me.ToolTip1.SetToolTip(Me.BtnSaveAs, "Generates and saves your raid to the location you choose.")
        Me.BtnSaveAs.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(308, 83)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.GroupSingle)
        Me.TabPage3.Controls.Add(Me.GroupAnnounce)
        Me.TabPage3.Controls.Add(Me.GroupArea)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(322, 356)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Raid Setup"
        '
        'GroupSingle
        '
        Me.GroupSingle.Controls.Add(Me.BtnSingle)
        Me.GroupSingle.Controls.Add(Me.BtnSingleRemove)
        Me.GroupSingle.Controls.Add(Me.BtnSingleAdd)
        Me.GroupSingle.Controls.Add(Me.GroupBox5)
        Me.GroupSingle.Controls.Add(Me.TxtSingleDelay)
        Me.GroupSingle.Controls.Add(Me.Label5)
        Me.GroupSingle.Controls.Add(Me.TxtSingleMonster)
        Me.GroupSingle.Controls.Add(Me.Label4)
        Me.GroupSingle.Controls.Add(Me.ListSingleSpawns)
        Me.GroupSingle.Location = New System.Drawing.Point(8, 42)
        Me.GroupSingle.Name = "GroupSingle"
        Me.GroupSingle.Size = New System.Drawing.Size(309, 30)
        Me.GroupSingle.TabIndex = 9
        Me.GroupSingle.TabStop = False
        '
        'BtnSingle
        '
        Me.BtnSingle.Location = New System.Drawing.Point(0, 0)
        Me.BtnSingle.Name = "BtnSingle"
        Me.BtnSingle.Size = New System.Drawing.Size(309, 23)
        Me.BtnSingle.TabIndex = 19
        Me.BtnSingle.Text = "SingleSpawns"
        Me.BtnSingle.UseVisualStyleBackColor = True
        '
        'BtnSingleRemove
        '
        Me.BtnSingleRemove.Location = New System.Drawing.Point(124, 240)
        Me.BtnSingleRemove.Name = "BtnSingleRemove"
        Me.BtnSingleRemove.Size = New System.Drawing.Size(57, 23)
        Me.BtnSingleRemove.TabIndex = 18
        Me.BtnSingleRemove.Text = "Remove"
        Me.BtnSingleRemove.UseVisualStyleBackColor = True
        '
        'BtnSingleAdd
        '
        Me.BtnSingleAdd.Location = New System.Drawing.Point(61, 240)
        Me.BtnSingleAdd.Name = "BtnSingleAdd"
        Me.BtnSingleAdd.Size = New System.Drawing.Size(57, 23)
        Me.BtnSingleAdd.TabIndex = 17
        Me.BtnSingleAdd.Text = "Add"
        Me.BtnSingleAdd.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtSingleZ)
        Me.GroupBox5.Controls.Add(Me.TxtSingleY)
        Me.GroupBox5.Controls.Add(Me.TxtSingleX)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(189, 155)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(114, 102)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Spawn Position"
        '
        'TxtSingleZ
        '
        Me.TxtSingleZ.Location = New System.Drawing.Point(31, 74)
        Me.TxtSingleZ.Name = "TxtSingleZ"
        Me.TxtSingleZ.Size = New System.Drawing.Size(77, 20)
        Me.TxtSingleZ.TabIndex = 5
        '
        'TxtSingleY
        '
        Me.TxtSingleY.Location = New System.Drawing.Point(31, 45)
        Me.TxtSingleY.Name = "TxtSingleY"
        Me.TxtSingleY.Size = New System.Drawing.Size(77, 20)
        Me.TxtSingleY.TabIndex = 4
        '
        'TxtSingleX
        '
        Me.TxtSingleX.Location = New System.Drawing.Point(31, 16)
        Me.TxtSingleX.Name = "TxtSingleX"
        Me.TxtSingleX.Size = New System.Drawing.Size(77, 20)
        Me.TxtSingleX.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Z:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Y:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "X:"
        '
        'TxtSingleDelay
        '
        Me.TxtSingleDelay.Location = New System.Drawing.Point(9, 214)
        Me.TxtSingleDelay.Name = "TxtSingleDelay"
        Me.TxtSingleDelay.Size = New System.Drawing.Size(69, 20)
        Me.TxtSingleDelay.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Delay:"
        '
        'TxtSingleMonster
        '
        Me.TxtSingleMonster.Location = New System.Drawing.Point(9, 171)
        Me.TxtSingleMonster.Name = "TxtSingleMonster"
        Me.TxtSingleMonster.Size = New System.Drawing.Size(100, 20)
        Me.TxtSingleMonster.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Monster:"
        '
        'ListSingleSpawns
        '
        Me.ListSingleSpawns.ContextMenuStrip = Me.ContextList
        Me.ListSingleSpawns.FormattingEnabled = True
        Me.ListSingleSpawns.Location = New System.Drawing.Point(6, 41)
        Me.ListSingleSpawns.Name = "ListSingleSpawns"
        Me.ListSingleSpawns.Size = New System.Drawing.Size(303, 108)
        Me.ListSingleSpawns.TabIndex = 11
        '
        'ContextList
        '
        Me.ContextList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextList.Name = "ContextList"
        Me.ContextList.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'GroupAnnounce
        '
        Me.GroupAnnounce.Controls.Add(Me.BtnAnnounce)
        Me.GroupAnnounce.Controls.Add(Me.BtnAnnounceRemove)
        Me.GroupAnnounce.Controls.Add(Me.BtnAnnounceAdd)
        Me.GroupAnnounce.Controls.Add(Me.ComboAnnounceType)
        Me.GroupAnnounce.Controls.Add(Me.Label3)
        Me.GroupAnnounce.Controls.Add(Me.TxtAnnouncement)
        Me.GroupAnnounce.Controls.Add(Me.Label2)
        Me.GroupAnnounce.Controls.Add(Me.TxtAnnounceDelay)
        Me.GroupAnnounce.Controls.Add(Me.Label1)
        Me.GroupAnnounce.Controls.Add(Me.ListAnnouncements)
        Me.GroupAnnounce.Location = New System.Drawing.Point(8, 6)
        Me.GroupAnnounce.Name = "GroupAnnounce"
        Me.GroupAnnounce.Size = New System.Drawing.Size(309, 30)
        Me.GroupAnnounce.TabIndex = 8
        Me.GroupAnnounce.TabStop = False
        '
        'BtnAnnounce
        '
        Me.BtnAnnounce.Location = New System.Drawing.Point(0, 0)
        Me.BtnAnnounce.Name = "BtnAnnounce"
        Me.BtnAnnounce.Size = New System.Drawing.Size(309, 23)
        Me.BtnAnnounce.TabIndex = 18
        Me.BtnAnnounce.Text = "Announcements"
        Me.BtnAnnounce.UseVisualStyleBackColor = True
        '
        'BtnAnnounceRemove
        '
        Me.BtnAnnounceRemove.Location = New System.Drawing.Point(157, 233)
        Me.BtnAnnounceRemove.Name = "BtnAnnounceRemove"
        Me.BtnAnnounceRemove.Size = New System.Drawing.Size(57, 23)
        Me.BtnAnnounceRemove.TabIndex = 17
        Me.BtnAnnounceRemove.Text = "Remove"
        Me.BtnAnnounceRemove.UseVisualStyleBackColor = True
        '
        'BtnAnnounceAdd
        '
        Me.BtnAnnounceAdd.Location = New System.Drawing.Point(94, 233)
        Me.BtnAnnounceAdd.Name = "BtnAnnounceAdd"
        Me.BtnAnnounceAdd.Size = New System.Drawing.Size(57, 23)
        Me.BtnAnnounceAdd.TabIndex = 16
        Me.BtnAnnounceAdd.Text = "Add"
        Me.BtnAnnounceAdd.UseVisualStyleBackColor = True
        '
        'ComboAnnounceType
        '
        Me.ComboAnnounceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAnnounceType.FormattingEnabled = True
        Me.ComboAnnounceType.Items.AddRange(New Object() {"Event", "Default", "Warning", "Small Status"})
        Me.ComboAnnounceType.Location = New System.Drawing.Point(168, 153)
        Me.ComboAnnounceType.Name = "ComboAnnounceType"
        Me.ComboAnnounceType.Size = New System.Drawing.Size(96, 21)
        Me.ComboAnnounceType.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Type:"
        '
        'TxtAnnouncement
        '
        Me.TxtAnnouncement.Location = New System.Drawing.Point(5, 207)
        Me.TxtAnnouncement.Name = "TxtAnnouncement"
        Me.TxtAnnouncement.Size = New System.Drawing.Size(268, 20)
        Me.TxtAnnouncement.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Announcement:"
        '
        'TxtAnnounceDelay
        '
        Me.TxtAnnounceDelay.Location = New System.Drawing.Point(5, 153)
        Me.TxtAnnounceDelay.Name = "TxtAnnounceDelay"
        Me.TxtAnnounceDelay.Size = New System.Drawing.Size(69, 20)
        Me.TxtAnnounceDelay.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Delay:"
        '
        'ListAnnouncements
        '
        Me.ListAnnouncements.ContextMenuStrip = Me.ContextList
        Me.ListAnnouncements.FormattingEnabled = True
        Me.ListAnnouncements.Location = New System.Drawing.Point(5, 39)
        Me.ListAnnouncements.Name = "ListAnnouncements"
        Me.ListAnnouncements.Size = New System.Drawing.Size(298, 95)
        Me.ListAnnouncements.TabIndex = 9
        '
        'GroupArea
        '
        Me.GroupArea.Controls.Add(Me.BtnArea)
        Me.GroupArea.Controls.Add(Me.BtnAreaRemove)
        Me.GroupArea.Controls.Add(Me.BtnAreaAdd)
        Me.GroupArea.Controls.Add(Me.GroupBox3)
        Me.GroupArea.Controls.Add(Me.GroupBox2)
        Me.GroupArea.Controls.Add(Me.TxtAreaAmount)
        Me.GroupArea.Controls.Add(Me.Label11)
        Me.GroupArea.Controls.Add(Me.TxtAreaDelay)
        Me.GroupArea.Controls.Add(Me.Label10)
        Me.GroupArea.Controls.Add(Me.TxtAreaMonster)
        Me.GroupArea.Controls.Add(Me.Label9)
        Me.GroupArea.Controls.Add(Me.ListAreaSpawns)
        Me.GroupArea.Location = New System.Drawing.Point(8, 78)
        Me.GroupArea.Name = "GroupArea"
        Me.GroupArea.Size = New System.Drawing.Size(309, 30)
        Me.GroupArea.TabIndex = 0
        Me.GroupArea.TabStop = False
        '
        'BtnArea
        '
        Me.BtnArea.Location = New System.Drawing.Point(0, 0)
        Me.BtnArea.Name = "BtnArea"
        Me.BtnArea.Size = New System.Drawing.Size(309, 23)
        Me.BtnArea.TabIndex = 24
        Me.BtnArea.Text = "AreaSpawns"
        Me.BtnArea.UseVisualStyleBackColor = True
        '
        'BtnAreaRemove
        '
        Me.BtnAreaRemove.Location = New System.Drawing.Point(162, 243)
        Me.BtnAreaRemove.Name = "BtnAreaRemove"
        Me.BtnAreaRemove.Size = New System.Drawing.Size(57, 23)
        Me.BtnAreaRemove.TabIndex = 23
        Me.BtnAreaRemove.Text = "Remove"
        Me.BtnAreaRemove.UseVisualStyleBackColor = True
        '
        'BtnAreaAdd
        '
        Me.BtnAreaAdd.Location = New System.Drawing.Point(99, 243)
        Me.BtnAreaAdd.Name = "BtnAreaAdd"
        Me.BtnAreaAdd.Size = New System.Drawing.Size(57, 23)
        Me.BtnAreaAdd.TabIndex = 22
        Me.BtnAreaAdd.Text = "Add"
        Me.BtnAreaAdd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtAreaToZ)
        Me.GroupBox3.Controls.Add(Me.TxtAreaToY)
        Me.GroupBox3.Controls.Add(Me.TxtAreaToX)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(225, 135)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(75, 102)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "To Position"
        '
        'TxtAreaToZ
        '
        Me.TxtAreaToZ.Location = New System.Drawing.Point(23, 74)
        Me.TxtAreaToZ.Name = "TxtAreaToZ"
        Me.TxtAreaToZ.Size = New System.Drawing.Size(47, 20)
        Me.TxtAreaToZ.TabIndex = 5
        '
        'TxtAreaToY
        '
        Me.TxtAreaToY.Location = New System.Drawing.Point(23, 45)
        Me.TxtAreaToY.Name = "TxtAreaToY"
        Me.TxtAreaToY.Size = New System.Drawing.Size(47, 20)
        Me.TxtAreaToY.TabIndex = 4
        '
        'TxtAreaToX
        '
        Me.TxtAreaToX.Location = New System.Drawing.Point(23, 16)
        Me.TxtAreaToX.Name = "TxtAreaToX"
        Me.TxtAreaToX.Size = New System.Drawing.Size(47, 20)
        Me.TxtAreaToX.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Z:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(17, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Y:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "X:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtAreaFromZ)
        Me.GroupBox2.Controls.Add(Me.TxtAreaFromY)
        Me.GroupBox2.Controls.Add(Me.TxtAreaFromX)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(134, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(85, 102)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "From Position"
        '
        'TxtAreaFromZ
        '
        Me.TxtAreaFromZ.Location = New System.Drawing.Point(23, 74)
        Me.TxtAreaFromZ.Name = "TxtAreaFromZ"
        Me.TxtAreaFromZ.Size = New System.Drawing.Size(47, 20)
        Me.TxtAreaFromZ.TabIndex = 5
        '
        'TxtAreaFromY
        '
        Me.TxtAreaFromY.Location = New System.Drawing.Point(23, 45)
        Me.TxtAreaFromY.Name = "TxtAreaFromY"
        Me.TxtAreaFromY.Size = New System.Drawing.Size(47, 20)
        Me.TxtAreaFromY.TabIndex = 4
        '
        'TxtAreaFromX
        '
        Me.TxtAreaFromX.Location = New System.Drawing.Point(23, 16)
        Me.TxtAreaFromX.Name = "TxtAreaFromX"
        Me.TxtAreaFromX.Size = New System.Drawing.Size(47, 20)
        Me.TxtAreaFromX.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Z:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Y:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "X:"
        '
        'TxtAreaAmount
        '
        Me.TxtAreaAmount.Location = New System.Drawing.Point(9, 229)
        Me.TxtAreaAmount.Name = "TxtAreaAmount"
        Me.TxtAreaAmount.Size = New System.Drawing.Size(69, 20)
        Me.TxtAreaAmount.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Amount:"
        '
        'TxtAreaDelay
        '
        Me.TxtAreaDelay.Location = New System.Drawing.Point(9, 188)
        Me.TxtAreaDelay.Name = "TxtAreaDelay"
        Me.TxtAreaDelay.Size = New System.Drawing.Size(69, 20)
        Me.TxtAreaDelay.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Delay:"
        '
        'TxtAreaMonster
        '
        Me.TxtAreaMonster.Location = New System.Drawing.Point(9, 148)
        Me.TxtAreaMonster.Name = "TxtAreaMonster"
        Me.TxtAreaMonster.Size = New System.Drawing.Size(100, 20)
        Me.TxtAreaMonster.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Monster:"
        '
        'ListAreaSpawns
        '
        Me.ListAreaSpawns.ContextMenuStrip = Me.ContextList
        Me.ListAreaSpawns.FormattingEnabled = True
        Me.ListAreaSpawns.Location = New System.Drawing.Point(6, 34)
        Me.ListAreaSpawns.Name = "ListAreaSpawns"
        Me.ListAreaSpawns.Size = New System.Drawing.Size(294, 95)
        Me.ListAreaSpawns.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 443)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OT RaidMaker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupSingle.ResumeLayout(False)
        Me.GroupSingle.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ContextList.ResumeLayout(False)
        Me.GroupAnnounce.ResumeLayout(False)
        Me.GroupAnnounce.PerformLayout()
        Me.GroupArea.ResumeLayout(False)
        Me.GroupArea.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnSaveAs As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnAbout As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtRaidDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtRaids As System.Windows.Forms.TextBox
    Friend WithEvents BtnLoadRaid As System.Windows.Forms.Button
    Friend WithEvents GroupArea As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAreaRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAreaAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAreaToZ As System.Windows.Forms.TextBox
    Friend WithEvents TxtAreaToY As System.Windows.Forms.TextBox
    Friend WithEvents TxtAreaToX As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAreaFromZ As System.Windows.Forms.TextBox
    Friend WithEvents TxtAreaFromY As System.Windows.Forms.TextBox
    Friend WithEvents TxtAreaFromX As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtAreaAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtAreaDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtAreaMonster As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListAreaSpawns As System.Windows.Forms.ListBox
    Friend WithEvents GroupSingle As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSingleRemove As System.Windows.Forms.Button
    Friend WithEvents BtnSingleAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSingleZ As System.Windows.Forms.TextBox
    Friend WithEvents TxtSingleY As System.Windows.Forms.TextBox
    Friend WithEvents TxtSingleX As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSingleDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSingleMonster As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListSingleSpawns As System.Windows.Forms.ListBox
    Friend WithEvents GroupAnnounce As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAnnounce As System.Windows.Forms.Button
    Friend WithEvents BtnAnnounceRemove As System.Windows.Forms.Button
    Friend WithEvents BtnAnnounceAdd As System.Windows.Forms.Button
    Friend WithEvents ComboAnnounceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtAnnouncement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtAnnounceDelay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListAnnouncements As System.Windows.Forms.ListBox
    Friend WithEvents BtnArea As System.Windows.Forms.Button
    Friend WithEvents BtnSingle As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtRaidsLoc As System.Windows.Forms.TextBox
    Friend WithEvents BtnBrowseRaidsLoc As System.Windows.Forms.Button
    Friend WithEvents ChkEditRaids As System.Windows.Forms.CheckBox
    Friend WithEvents ChkClearFields As System.Windows.Forms.CheckBox
    Friend WithEvents ContextList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
