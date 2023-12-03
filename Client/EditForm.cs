using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Вопросы в студию
- Почему NumericUpDown работают неадекватно

 
 */
namespace Client
{
    public partial class EditForm : Form
    {
        private Computer comp;
        private int mod; // 1 - Изменение, 0 - Добавить
        private ServiceReference1.ContractClient client;

        public EditForm(ServiceReference1.ContractClient _client, Computer _comp, int _mod)
        {
            InitializeComponent();

            client = _client;
            mod = _mod;

            if (mod == 1)
            {
                id.ReadOnly = true;
                id.Enabled = false;
            }

            comp = _comp;

            id.Value = comp.ID;
            power.Value = comp.Power;
            memory.Value = comp.Memory;

            name.Text = comp.Name;
            cpuName.Text = comp.CPU;
            gpuName.Text = comp.GPU;
            mother.Text = comp.Motherboard;
            
            ssd.Checked = comp.SSD;
            hdd.Checked = comp.HDD;
            os.Checked = comp.OS;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var ID = (int)id.Value;
            var Power = (int)power.Value;
            var Memory = (int)memory.Value;

            var Name = name.Text;
            var cpu = cpuName.Text;
            var gpu = gpuName.Text;
            var Mom = mother.Text;

            var SSD = ssd.Checked;
            var HDD = hdd.Checked;
            var OS = os.Checked;


            try
            {
                Computer comp = new Computer(ID, Name, cpu, gpu, Mom, Power, Memory, SSD, HDD, OS);

                try
                {
                    if (mod == 0)
                        client.AddComputer(comp);
                    else
                        client.UpdateComputer(comp);

                    DialogResult = DialogResult.OK;

                }
                catch (FaultException<SQLError> ex) 
                {
                    MessageBox.Show($"{ex.Detail.Description}\n{ex.Detail.Command}\n{ex.Detail.Connection}", "O_o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(FaultException<ValueError> ex)
            {
                MessageBox.Show($"{ex.Detail.nameValue}\n{ex.Detail.errString}\n{ex.Detail.haveToBe}", "O_o", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите отменить изменения?", "O_o", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
