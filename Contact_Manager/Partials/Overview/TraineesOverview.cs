using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contact_Manager.Partials.Overview
{
    public partial class TraineesOverview : FrmOverview
    {
        public TraineesOverview()
        {
            InitializeComponent();
        }

        protected override dynamic GetCollectionList()
        {
            return DataContainer.GetTraineeCollection();
        }

        protected override void OpenEditDialog(int row)
        {
            throw new NotImplementedException();
        }

        protected override dynamic GetObjectFromIndex(int row)
        {
            throw new NotImplementedException();
        }

        protected override DialogResult AskForConfirmation(dynamic obj)
        {
            throw new NotImplementedException();
        }
    }
}
