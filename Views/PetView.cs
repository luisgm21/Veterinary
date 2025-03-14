using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary.Views
{
    public partial class PetView : Form, IPetView
    {
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            btnCerrar.Click += delegate { Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string PetID
        {
            get { return txtPetID.Text; }
            set { txtPetID.Text = value; }
        }

        public string PetName
        {
            get { return txtPetName.Text; }
            set { txtPetName.Text = value; }
        }

        public string PetType
        {
            get { return txtPetType.Text; }
            set { txtPetType.Text = value; }
        }

        public string PetColour
        {
            get { return txtPetColour.Text; }
            set { txtPetColour.Text = value; }
        }

        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        private bool _isEdit;
        public bool IsEdit
        {
            get { return _isEdit; }
            set { _isEdit = value; }
        }

        private bool _isSuccessful;
        public bool IsSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }

        private static PetView _instance;
        public static PetView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new PetView();
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                {
                    _instance.WindowState = FormWindowState.Normal;
                }
                _instance.BringToFront();
            }
                return _instance;
        }
    }
}
