using CC01.BLL;
using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formEtablisement
{
    public partial class Form1 : Form
    {
        private Action callback;
        private EcoleBLL ecoleBLL;
        private Ecole oldEco;
        public Form1()
        {
            InitializeComponent();
            dataGridViewecole.AutoGenerateColumns = false;
            ecoleBLL = new EcoleBLL(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public Form1(Action callback) : this()
        {
            this.callback = callback;
        }

        public Form1(Ecole ecole, Action callback) : this(callback)
        {
            this.oldEco = ecole;
            txtNome.Text = ecole.NomEcole;
            txtEmaile.Text = ecole.EmailEcole;
            txtcontactee.Text = ecole.ContactEcole.ToString();
            pictureBoxlogoecole.Image = ecole.Logo != null ? Image.FromStream(new MemoryStream(ecole.Logo)) : null;
        }

        private void pictureBoxlogoecole_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisissez le logo";
            ofd.Filter = "Image File|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxlogoecole.ImageLocation = ofd.FileName;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForm();

                Ecole newEco = new Ecole(
                    !String.IsNullOrEmpty(pictureBoxlogoecole.ImageLocation) ? File.ReadAllBytes(pictureBoxlogoecole.ImageLocation) : this.oldEco?.Logo,
                    txtNome.Text.ToUpper(),
                     long.Parse(txtcontactee.Text),
                    txtEmaile.Text
                    );

                EcoleBLL ecoBlo = new EcoleBLL(ConfigurationManager.AppSettings["DbFolder"]);
                if (this.oldEco == null)
                {
                    ecoBlo.CreateEcole(newEco);
                }
                else
                {
                    ecoBlo.EditEcole(oldEco, newEco);
                }
                ecoBlo.CreateEcole(newEco);
                MessageBox.Show(
                    "Enregistrement éffectué !",
                     "Confirmé",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                    );
                if (callback != null)
                    callback();

                if (oldEco != null)
                    Close();
                txtNome.Clear();
                txtEmaile.Clear();
                txtcontactee.Clear();
                txtNome.Focus();
            }
            catch (StrongTypingException ex)
            {

                MessageBox.Show
                    (
                    ex.Message,
                    "Typing error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                   );
            }
            catch (DuplicateNameException ex)
            {

                MessageBox.Show
                    (
                    ex.Message,
                    "Duplicate error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                   );
            }
            catch (KeyNotFoundException ex)
            {

                MessageBox.Show
                    (
                    ex.Message,
                    "Not found error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                   );
            }

            catch (Exception ex)
            {
                ex.WriteToFile();
                using (StreamWriter sw = new StreamWriter("app.log", true))
                {
                    sw.WriteLine(ex.ToString());
                }
                MessageBox.Show
                    (
                    "An Error occured! Please try again",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                   );
            }
            loadData();
           
        }
        private void loadData()
        {
            string value = txtRecherchEcole.Text.ToLower();
            var ecoles = ecoleBLL.GetBy
            (
                x =>
                x.NomEcole.ToLower().Contains(value)
            ).OrderBy(x => x.NomEcole).ToArray();
            dataGridViewecole.DataSource = null;
            dataGridViewecole.DataSource = ecoles;
            dataGridViewecole.ClearSelection();
        }
        private void CheckForm()
        {
            string text = string.Empty;
            txtNome.BackColor = Color.White;
            txtNome.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                text += "-------------Please enter the school name!\n";
                txtNome.BackColor = Color.Pink;
            }

            if (string.IsNullOrWhiteSpace(txtcontactee.Text))
            {
                text += "-------- Please enter the name! \n";
                txtcontactee.BackColor = Color.Pink;
            }

            if (!string.IsNullOrEmpty(text))
            {
                throw new StrongTypingException(text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewecole.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridViewecole.SelectedRows.Count; i++)
                {
                    Form f = new Form1
                        (
                            dataGridViewecole.SelectedRows[i].DataBoundItem as Ecole,
                            loadData
                        );
                    this.Hide();
                    f.Show();
                    f.WindowState = FormWindowState.Maximized;
                }

            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewecole.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this student(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridViewecole.SelectedRows.Count; i++)
                    {
                        ecoleBLL.DeleteEcole(dataGridViewecole.SelectedRows[i].DataBoundItem as Ecole);
                    }
                    loadData();
                }
            }
        }
    }
}
