namespace Instigate.Meta.WinForms.App
{
   partial class CreateMetaTypeControl
   {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.buttonCreate = new System.Windows.Forms.Button();
         this.labelName = new System.Windows.Forms.Label();
         this.labelDescription = new System.Windows.Forms.Label();
         this.textBoxName = new System.Windows.Forms.TextBox();
         this.textBoxDescription = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // buttonCreate
         // 
         this.buttonCreate.Location = new System.Drawing.Point(242, 208);
         this.buttonCreate.Name = "buttonCreate";
         this.buttonCreate.Size = new System.Drawing.Size(75, 23);
         this.buttonCreate.TabIndex = 0;
         this.buttonCreate.Text = "Create";
         this.buttonCreate.UseVisualStyleBackColor = true;
         // 
         // labelName
         // 
         this.labelName.AutoSize = true;
         this.labelName.Location = new System.Drawing.Point(30, 30);
         this.labelName.Name = "labelName";
         this.labelName.Size = new System.Drawing.Size(35, 13);
         this.labelName.TabIndex = 1;
         this.labelName.Text = "Name";
         // 
         // labelDescription
         // 
         this.labelDescription.AutoSize = true;
         this.labelDescription.Location = new System.Drawing.Point(30, 69);
         this.labelDescription.Name = "labelDescription";
         this.labelDescription.Size = new System.Drawing.Size(60, 13);
         this.labelDescription.TabIndex = 2;
         this.labelDescription.Text = "Description";
         // 
         // textBoxName
         // 
         this.textBoxName.Location = new System.Drawing.Point(115, 30);
         this.textBoxName.Name = "textBoxName";
         this.textBoxName.Size = new System.Drawing.Size(202, 20);
         this.textBoxName.TabIndex = 3;
         // 
         // textBoxDescription
         // 
         this.textBoxDescription.Location = new System.Drawing.Point(115, 69);
         this.textBoxDescription.Multiline = true;
         this.textBoxDescription.Name = "textBoxDescription";
         this.textBoxDescription.Size = new System.Drawing.Size(202, 97);
         this.textBoxDescription.TabIndex = 4;
         // 
         // CreateMetaTypeControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.textBoxDescription);
         this.Controls.Add(this.textBoxName);
         this.Controls.Add(this.labelDescription);
         this.Controls.Add(this.labelName);
         this.Controls.Add(this.buttonCreate);
         this.Name = "CreateMetaTypeControl";
         this.Size = new System.Drawing.Size(330, 245);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button buttonCreate;
      private System.Windows.Forms.Label labelName;
      private System.Windows.Forms.Label labelDescription;
      private System.Windows.Forms.TextBox textBoxName;
      private System.Windows.Forms.TextBox textBoxDescription;
   }
}
