﻿namespace PublicManager.Modules.Module_B.DataExport
{
    partial class ModuleController
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rcTopBar = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnExportToExcel_DutyUnit = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddProject = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteProject = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditProject = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportToWord = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportToExcel_All = new DevExpress.XtraBars.BarButtonItem();
            this.rpMaster = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgElse = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.rcTopBar)).BeginInit();
            this.SuspendLayout();
            // 
            // rcTopBar
            // 
            this.rcTopBar.ExpandCollapseItem.Id = 0;
            this.rcTopBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcTopBar.ExpandCollapseItem,
            this.btnExportToExcel_DutyUnit,
            this.btnAddProject,
            this.btnDeleteProject,
            this.btnEditProject,
            this.btnExportToWord,
            this.btnExportToExcel_All});
            this.rcTopBar.Location = new System.Drawing.Point(0, 0);
            this.rcTopBar.MaxItemId = 12;
            this.rcTopBar.Name = "rcTopBar";
            this.rcTopBar.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMaster});
            this.rcTopBar.Size = new System.Drawing.Size(1182, 145);
            // 
            // btnExportToExcel_DutyUnit
            // 
            this.btnExportToExcel_DutyUnit.Caption = "导出到Excel(按责任单位导出)";
            this.btnExportToExcel_DutyUnit.Id = 6;
            this.btnExportToExcel_DutyUnit.LargeGlyph = global::PublicManager.Properties.Resources.export;
            this.btnExportToExcel_DutyUnit.Name = "btnExportToExcel_DutyUnit";
            this.btnExportToExcel_DutyUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_DutyUnit_ItemClick);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Caption = "新增专项项目";
            this.btnAddProject.Id = 7;
            this.btnAddProject.LargeGlyph = global::PublicManager.Properties.Resources.add;
            this.btnAddProject.Name = "btnAddProject";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Caption = "删除专项项目";
            this.btnDeleteProject.Id = 8;
            this.btnDeleteProject.LargeGlyph = global::PublicManager.Properties.Resources.delete;
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnEditProject
            // 
            this.btnEditProject.Caption = "编辑专项项目";
            this.btnEditProject.Id = 9;
            this.btnEditProject.LargeGlyph = global::PublicManager.Properties.Resources.edit;
            this.btnEditProject.Name = "btnEditProject";
            // 
            // btnExportToWord
            // 
            this.btnExportToWord.Caption = "导出到Word";
            this.btnExportToWord.Id = 10;
            this.btnExportToWord.LargeGlyph = global::PublicManager.Properties.Resources.export;
            this.btnExportToWord.Name = "btnExportToWord";
            this.btnExportToWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToWord_ItemClick);
            // 
            // btnExportToExcel_All
            // 
            this.btnExportToExcel_All.Caption = "导出到Excel(全部)";
            this.btnExportToExcel_All.Id = 11;
            this.btnExportToExcel_All.LargeGlyph = global::PublicManager.Properties.Resources.export;
            this.btnExportToExcel_All.Name = "btnExportToExcel_All";
            this.btnExportToExcel_All.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportToExcel_All_ItemClick);
            // 
            // rpMaster
            // 
            this.rpMaster.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgElse});
            this.rpMaster.Name = "rpMaster";
            this.rpMaster.Text = "论证报告书";
            // 
            // rpgElse
            // 
            this.rpgElse.ItemLinks.Add(this.btnExportToExcel_All);
            this.rpgElse.ItemLinks.Add(this.btnExportToExcel_DutyUnit);
            this.rpgElse.ItemLinks.Add(this.btnExportToWord);
            this.rpgElse.Name = "rpgElse";
            this.rpgElse.Text = "其它";
            // 
            // ModuleController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rcTopBar);
            this.Name = "ModuleController";
            this.Size = new System.Drawing.Size(1182, 152);
            ((System.ComponentModel.ISupportInitialize)(this.rcTopBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rcTopBar;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel_DutyUnit;
        private DevExpress.XtraBars.BarButtonItem btnAddProject;
        private DevExpress.XtraBars.BarButtonItem btnDeleteProject;
        private DevExpress.XtraBars.BarButtonItem btnEditProject;
        private DevExpress.XtraBars.BarButtonItem btnExportToWord;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMaster;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgElse;
        private DevExpress.XtraBars.BarButtonItem btnExportToExcel_All;
    }
}
