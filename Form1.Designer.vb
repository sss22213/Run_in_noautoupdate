<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.檔案ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.刪除歷史紀錄ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關閉ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.選項ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.煲機音檔來源設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.設定檔管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關於ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RUNIN歷史紀錄ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關於ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "開始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "計時器:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(150, 134)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "欲Run的時間(單位:小時):"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(245, 186)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "30"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "休息(單位:分鐘):"
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.檔案ToolStripMenuItem, Me.選項ToolStripMenuItem1, Me.關於ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(394, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '檔案ToolStripMenuItem
        '
        Me.檔案ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.刪除歷史紀錄ToolStripMenuItem, Me.關閉ToolStripMenuItem})
        Me.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem"
        Me.檔案ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.檔案ToolStripMenuItem.Text = "檔案"
        '
        '刪除歷史紀錄ToolStripMenuItem
        '
        Me.刪除歷史紀錄ToolStripMenuItem.Name = "刪除歷史紀錄ToolStripMenuItem"
        Me.刪除歷史紀錄ToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.刪除歷史紀錄ToolStripMenuItem.Text = "刪除歷史紀錄"
        '
        '關閉ToolStripMenuItem
        '
        Me.關閉ToolStripMenuItem.Name = "關閉ToolStripMenuItem"
        Me.關閉ToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.關閉ToolStripMenuItem.Text = "關閉"
        '
        '選項ToolStripMenuItem1
        '
        Me.選項ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.煲機音檔來源設定ToolStripMenuItem, Me.設定檔管理ToolStripMenuItem})
        Me.選項ToolStripMenuItem1.Name = "選項ToolStripMenuItem1"
        Me.選項ToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.選項ToolStripMenuItem1.Text = "選項"
        '
        '煲機音檔來源設定ToolStripMenuItem
        '
        Me.煲機音檔來源設定ToolStripMenuItem.Name = "煲機音檔來源設定ToolStripMenuItem"
        Me.煲機音檔來源設定ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.煲機音檔來源設定ToolStripMenuItem.Text = "煲機音檔來源設定"
        '
        '設定檔管理ToolStripMenuItem
        '
        Me.設定檔管理ToolStripMenuItem.Name = "設定檔管理ToolStripMenuItem"
        Me.設定檔管理ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.設定檔管理ToolStripMenuItem.Text = "設定檔管理"
        '
        '關於ToolStripMenuItem
        '
        Me.關於ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RUNIN歷史紀錄ToolStripMenuItem, Me.關於ToolStripMenuItem1})
        Me.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem"
        Me.關於ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.關於ToolStripMenuItem.Text = "關於"
        '
        'RUNIN歷史紀錄ToolStripMenuItem
        '
        Me.RUNIN歷史紀錄ToolStripMenuItem.Name = "RUNIN歷史紀錄ToolStripMenuItem"
        Me.RUNIN歷史紀錄ToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RUNIN歷史紀錄ToolStripMenuItem.Text = "RUN IN 歷史紀錄"
        '
        '關於ToolStripMenuItem1
        '
        Me.關於ToolStripMenuItem1.Name = "關於ToolStripMenuItem1"
        Me.關於ToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.關於ToolStripMenuItem1.Text = "關於"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "RUN IN停止"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(91, 186)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(51, 22)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = "2.3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "每(單位:小時)"
        '
        'BackgroundWorker3
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(135, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "停止"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 270)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Burn in Run"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 關於ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 關於ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RUNIN歷史紀錄ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents 選項ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 煲機音檔來源設定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 檔案ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 關閉ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 設定檔管理ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 刪除歷史紀錄ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
