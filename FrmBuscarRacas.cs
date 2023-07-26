#region [References]

using CatAsService.Domain;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace CatAsService
{
    public partial class FrmBuscarRacas : Form
    {
        #region [Constants]

        private const string textFormTitle = "Sobre gatos - Buscar Raças";
        private const string textFormTitleStatus = "Sobre gatos - Buscar Raças - {0}";

        #endregion

        #region [Properties]

        private List<Breed> BreedsList { get; set; }

        #endregion

        #region [Singleton]

        private List<Breed> GetAllBreeds()
        {
            if (BreedsList == null)
            {
                LoadBreedsList();
            }
            return BreedsList;
        }

        #endregion

        #region [Constructor]

        public FrmBuscarRacas()
        {
            InitializeComponent();
        }

        #endregion

        #region [Events]

        private void BtnBuscarInformacoes_Click(object sender, System.EventArgs e)
        {
            btnBuscarInformacoes.Enabled = false;
            btnMudarImagem.Enabled = false;
            cboRacas.Enabled = false;

            UpdateStatusForm("Carregando informações ...");

            LoadFields(GetBreed(cboRacas.Text));

            ResetStatusForm();
            btnBuscarInformacoes.Enabled = true;
            btnMudarImagem.Enabled = true;
            cboRacas.Enabled = true;
        }

        private void FrmBuscarRacas_Load(object sender, EventArgs e)
        {
            UpdateStatusForm("Carregando as raças ...");

            timerInicializacao.Start();
        }

        private void timerInicializacao_Tick(object sender, EventArgs e)
        {
            LoadComboBreeds();
            timerInicializacao.Stop();
            btnBuscarInformacoes.Enabled = true;
            cboRacas.Enabled = true;
            ResetStatusForm();
        }

        private void BtnMudarImagem_Click(object sender, EventArgs e)
        {
            UpdateStatusForm("Carregando nova imagem ...");

            LoadFields(GetBreed(cboRacas.Text));

            ResetStatusForm();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region [Methods]

        private void LoadComboBreeds()
        {
            cboRacas.DisplayMember = "name";
            cboRacas.DataSource = GetAllBreeds();
        }

        private void LoadBreedsList()
        {
            var breedsList = new List<Breed>();

            var client = new RestClient(Util.EndpointAPIBreeds);
            var request = new RestRequest();
            var response = client.Execute(request);

            var content = response.Content;
            dynamic json = JsonConvert.DeserializeObject(content);

            breedsList = json.ToObject<List<Breed>>();
            BreedsList = breedsList;
        }

        private Breed GetBreed(string nameBreed)
        {
            Breed breed = null;
            if (!string.IsNullOrEmpty(nameBreed))
            {
                breed = BreedsList.Where(x => x.name.Equals(nameBreed)).FirstOrDefault();
            }
            return breed;
        }

        private void LoadFields(Breed breed)
        {
            if (breed != null)
            {
                txtTemperamento.Text = breed.temperament;
                txtPaisOrigem.Text = breed.origin;
                txtMediaIdade.Text = string.Concat(breed.life_span, " anos");
                txtDescricao.Text = breed.description;
                LoadImageBreed(breed.id);
            }
        }

        private void LoadImageBreed(string breedId)
        {
            var image = GetImageBreed(breedId);
            if (image != null)
            {
                LoadPictureBoxBreed(image.url);
            }
        }

        private Image GetImageBreed(string breedId)
        {
            Image image = null;

            var client = new RestClient(Util.GetEndpointAPISearchBreed(breedId));
            var request = new RestRequest();
            var response = client.Execute(request);

            var content = response.Content;
            dynamic json = JsonConvert.DeserializeObject(content);

            var imageList = json.ToObject<List<Image>>();
            if (imageList != null && imageList.Count > 0)
            {
                image = imageList[0];
            }

            return image;
        }

        private void LoadPictureBoxBreed(string url)
        {
            pcbImagem.Load(url);
        }

        private void UpdateStatusForm(string status)
        {
            this.Text = string.Format(textFormTitleStatus, status);
        }

        private void ResetStatusForm()
        {
            this.Text = textFormTitle;
        }

        #endregion
    }
}
