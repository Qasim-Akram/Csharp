using System.Runtime.CompilerServices;

namespace FirstWinFormsApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private Button Btnclickme;

    /// <summary>
    ///  Clean up any resources being used.
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

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Text = "Form1";
        
        Btnclickme=new Button();
        Btnclickme.Text="Click here";
        Btnclickme.Width=120;
        Btnclickme.Height=40;
        Btnclickme.Top=150;
        Btnclickme.Left=200;

        Btnclickme.Click+=Btnclickme_Click;
        this.Controls.Add(Btnclickme);

    
    }

    #endregion
}
