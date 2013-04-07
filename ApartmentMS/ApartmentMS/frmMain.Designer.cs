partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.bothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ownersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.apartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.leasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.apartmentToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.ownerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.leaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.apartmentToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        this.ownerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        this.leaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.apartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ownerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.leaseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ownerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.lstData = new System.Windows.Forms.ListBox();
        this.listBox1 = new System.Windows.Forms.ListBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.apartmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.leaseToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.apartmentToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.leaseIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.ownerToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
        this.apartmentToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
        this.listBox2 = new System.Windows.Forms.ListBox();
        this.label3 = new System.Windows.Forms.Label();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.sortByToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
        this.menuStrip1.TabIndex = 2;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.printToolStripMenuItem});
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        this.fileToolStripMenuItem.Text = "File";
        // 
        // openToolStripMenuItem
        // 
        this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.openToolStripMenuItem.Text = "Open";
        this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
        // 
        // exitToolStripMenuItem
        // 
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.exitToolStripMenuItem.Text = "Exit";
        this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        // 
        // printToolStripMenuItem
        // 
        this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bothToolStripMenuItem,
            this.ownersToolStripMenuItem,
            this.apartmentsToolStripMenuItem,
            this.leasesToolStripMenuItem});
        this.printToolStripMenuItem.Name = "printToolStripMenuItem";
        this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.printToolStripMenuItem.Text = "Print";
        // 
        // bothToolStripMenuItem
        // 
        this.bothToolStripMenuItem.Name = "bothToolStripMenuItem";
        this.bothToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
        this.bothToolStripMenuItem.Text = "All";
        // 
        // ownersToolStripMenuItem
        // 
        this.ownersToolStripMenuItem.Name = "ownersToolStripMenuItem";
        this.ownersToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
        this.ownersToolStripMenuItem.Text = "Owners";
        // 
        // apartmentsToolStripMenuItem
        // 
        this.apartmentsToolStripMenuItem.Name = "apartmentsToolStripMenuItem";
        this.apartmentsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
        this.apartmentsToolStripMenuItem.Text = "Apartments";
        // 
        // leasesToolStripMenuItem
        // 
        this.leasesToolStripMenuItem.Name = "leasesToolStripMenuItem";
        this.leasesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
        this.leasesToolStripMenuItem.Text = "Leases";
        // 
        // editToolStripMenuItem
        // 
        this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem1});
        this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        this.editToolStripMenuItem.Text = "Edit";
        // 
        // addToolStripMenuItem
        // 
        this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmentToolStripMenuItem2,
            this.ownerToolStripMenuItem2,
            this.leaseToolStripMenuItem});
        this.addToolStripMenuItem.Name = "addToolStripMenuItem";
        this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.addToolStripMenuItem.Text = "Add";
        // 
        // apartmentToolStripMenuItem2
        // 
        this.apartmentToolStripMenuItem2.Name = "apartmentToolStripMenuItem2";
        this.apartmentToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
        this.apartmentToolStripMenuItem2.Text = "Apartment";
        // 
        // ownerToolStripMenuItem2
        // 
        this.ownerToolStripMenuItem2.Name = "ownerToolStripMenuItem2";
        this.ownerToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
        this.ownerToolStripMenuItem2.Text = "Owner";
        // 
        // leaseToolStripMenuItem
        // 
        this.leaseToolStripMenuItem.Name = "leaseToolStripMenuItem";
        this.leaseToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
        this.leaseToolStripMenuItem.Text = "Lease";
        // 
        // deleteToolStripMenuItem
        // 
        this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmentToolStripMenuItem3,
            this.ownerToolStripMenuItem3,
            this.leaseToolStripMenuItem1});
        this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
        this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.deleteToolStripMenuItem.Text = "Delete";
        // 
        // apartmentToolStripMenuItem3
        // 
        this.apartmentToolStripMenuItem3.Name = "apartmentToolStripMenuItem3";
        this.apartmentToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
        this.apartmentToolStripMenuItem3.Text = "Apartment";
        // 
        // ownerToolStripMenuItem3
        // 
        this.ownerToolStripMenuItem3.Name = "ownerToolStripMenuItem3";
        this.ownerToolStripMenuItem3.Size = new System.Drawing.Size(131, 22);
        this.ownerToolStripMenuItem3.Text = "Owner";
        // 
        // leaseToolStripMenuItem1
        // 
        this.leaseToolStripMenuItem1.Name = "leaseToolStripMenuItem1";
        this.leaseToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
        this.leaseToolStripMenuItem1.Text = "Lease";
        // 
        // editToolStripMenuItem1
        // 
        this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartmentToolStripMenuItem,
            this.ownerToolStripMenuItem,
            this.leaseToolStripMenuItem2});
        this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
        this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
        this.editToolStripMenuItem1.Text = "Edit";
        // 
        // apartmentToolStripMenuItem
        // 
        this.apartmentToolStripMenuItem.Name = "apartmentToolStripMenuItem";
        this.apartmentToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
        this.apartmentToolStripMenuItem.Text = "Apartment";
        // 
        // ownerToolStripMenuItem
        // 
        this.ownerToolStripMenuItem.Name = "ownerToolStripMenuItem";
        this.ownerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
        this.ownerToolStripMenuItem.Text = "Owner";
        // 
        // leaseToolStripMenuItem2
        // 
        this.leaseToolStripMenuItem2.Name = "leaseToolStripMenuItem2";
        this.leaseToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
        this.leaseToolStripMenuItem2.Text = "Lease";
        // 
        // sortByToolStripMenuItem
        // 
        this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ownerToolStripMenuItem1,
            this.apartmentToolStripMenuItem1,
            this.leaseToolStripMenuItem3});
        this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
        this.sortByToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
        this.sortByToolStripMenuItem.Text = "Sort By";
        // 
        // ownerToolStripMenuItem1
        // 
        this.ownerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.apartmentToolStripMenuItem4});
        this.ownerToolStripMenuItem1.Name = "ownerToolStripMenuItem1";
        this.ownerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
        this.ownerToolStripMenuItem1.Text = "Owner";
        // 
        // lstData
        // 
        this.lstData.FormattingEnabled = true;
        this.lstData.Location = new System.Drawing.Point(12, 62);
        this.lstData.Name = "lstData";
        this.lstData.Size = new System.Drawing.Size(1041, 238);
        this.lstData.TabIndex = 3;
        // 
        // listBox1
        // 
        this.listBox1.FormattingEnabled = true;
        this.listBox1.Location = new System.Drawing.Point(12, 362);
        this.listBox1.Name = "listBox1";
        this.listBox1.Size = new System.Drawing.Size(1041, 316);
        this.listBox1.TabIndex = 4;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(7, 30);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(144, 29);
        this.label1.TabIndex = 5;
        this.label1.Text = "Apartments";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(12, 330);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(106, 29);
        this.label2.TabIndex = 6;
        this.label2.Text = "Leasers";
        // 
        // apartmentToolStripMenuItem1
        // 
        this.apartmentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.sizeToolStripMenuItem,
            this.leaseIDToolStripMenuItem});
        this.apartmentToolStripMenuItem1.Name = "apartmentToolStripMenuItem1";
        this.apartmentToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
        this.apartmentToolStripMenuItem1.Text = "Apartment";
        // 
        // leaseToolStripMenuItem3
        // 
        this.leaseToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem,
            this.ownerToolStripMenuItem4,
            this.apartmentToolStripMenuItem5});
        this.leaseToolStripMenuItem3.Name = "leaseToolStripMenuItem3";
        this.leaseToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
        this.leaseToolStripMenuItem3.Text = "Lease";
        // 
        // nameToolStripMenuItem
        // 
        this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
        this.nameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.nameToolStripMenuItem.Text = "Name";
        // 
        // apartmentToolStripMenuItem4
        // 
        this.apartmentToolStripMenuItem4.Name = "apartmentToolStripMenuItem4";
        this.apartmentToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
        this.apartmentToolStripMenuItem4.Text = "Apartment #";
        // 
        // toolStripMenuItem2
        // 
        this.toolStripMenuItem2.Name = "toolStripMenuItem2";
        this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
        this.toolStripMenuItem2.Text = "ID";
        // 
        // sizeToolStripMenuItem
        // 
        this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
        this.sizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.sizeToolStripMenuItem.Text = "Size";
        // 
        // leaseIDToolStripMenuItem
        // 
        this.leaseIDToolStripMenuItem.Name = "leaseIDToolStripMenuItem";
        this.leaseIDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.leaseIDToolStripMenuItem.Text = "Lease ID";
        // 
        // iDToolStripMenuItem
        // 
        this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
        this.iDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.iDToolStripMenuItem.Text = "ID";
        // 
        // ownerToolStripMenuItem4
        // 
        this.ownerToolStripMenuItem4.Name = "ownerToolStripMenuItem4";
        this.ownerToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
        this.ownerToolStripMenuItem4.Text = "Owner";
        // 
        // apartmentToolStripMenuItem5
        // 
        this.apartmentToolStripMenuItem5.Name = "apartmentToolStripMenuItem5";
        this.apartmentToolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
        this.apartmentToolStripMenuItem5.Text = "Apartment";
        // 
        // listBox2
        // 
        this.listBox2.FormattingEnabled = true;
        this.listBox2.Location = new System.Drawing.Point(12, 728);
        this.listBox2.Name = "listBox2";
        this.listBox2.Size = new System.Drawing.Size(1041, 290);
        this.listBox2.TabIndex = 7;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.Location = new System.Drawing.Point(13, 701);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(76, 24);
        this.label3.TabIndex = 8;
        this.label3.Text = "Leases";
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(1066, 1032);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.listBox2);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.listBox1);
        this.Controls.Add(this.lstData);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "frmMain";
        this.Text = "Apartment Management ";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ListBox lstData;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem apartmentToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem apartmentToolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ToolStripMenuItem bothToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ownersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem apartmentsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem apartmentToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ToolStripMenuItem leasesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem leaseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem leaseToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem leaseToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem apartmentToolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem apartmentToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem leaseIDToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem leaseToolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ownerToolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem apartmentToolStripMenuItem5;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.Label label3;
}