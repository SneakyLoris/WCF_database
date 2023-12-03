using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference1;
using Server;

namespace Client
{
    public partial class Form1 : Form
    {
        private BindingList<Computer> _values = new();
        ServiceReference1.ContractClient client = new ServiceReference1.ContractClient();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = _values;
        }

        private void AddButton(object sender, EventArgs e)
        {
            Computer comp = new Computer();
            EditForm edit = new(client, comp, 0);
            edit.ShowDialog(this);

            // уточнить что вводить вместо sender и e
            this.ReadDB(sender, e);
        }

        private void RefactorButton(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var curr = dataGridView1.SelectedRows[0]?.Index;
                Computer copy = _values[(int)curr].Copy();
                EditForm edit = new(client, copy, 1);
                edit.ShowDialog(this);

                this.ReadDB(sender, e);

            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования", "0_o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var curr = dataGridView1.SelectedRows[0]?.Index;
                client.DeleteComputer(_values[(int)curr]);

                this.ReadDB(sender, e);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления", "0_o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadDB(object sender, EventArgs e)
        {
            try
            {
                _values.Clear();
                var pull = client.GetComputers();
                foreach (var item in pull)
                    _values.Add(item);

                dataGridView1.DataSource = _values;
            }
            catch (FaultException<SQLError> ex)
            {
                MessageBox.Show($"{ex.Detail.Description}\n{ex.Detail.Command}\n{ex.Detail.Connection}", "O_oooo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
