﻿using System;
using System.Diagnostics;

namespace ScreenBrighter
{
    partial class SetScreenBrightService
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
            this.components = new System.ComponentModel.Container();
            this.ServiceLogger = new System.Diagnostics.EventLog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceLogger)).BeginInit();
            // 
            // ServiceLogger
            // 
            this.ServiceLogger.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // SetScreenBrightService
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.ServiceLogger)).EndInit();

        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Diagnostics.EventLog ServiceLogger;
        private System.Windows.Forms.Timer timer1;
    }
}
