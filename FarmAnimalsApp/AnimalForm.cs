using FarmAnimalsApp.Model;

namespace FarmAnimalsApp
{
    public partial class AnimalForm : Form
    {
        private Animal? animalSelected;

        const string COW = "Cow";
        const string ROOSTER = "Rooster";
        const string HORSE = "Horse";
        const string PIG = "Pig";
        const string SHEEP = "Sheep";

        private readonly string[] animalOptions = { COW, ROOSTER, HORSE, PIG, SHEEP };
      
        public AnimalForm()
        {
            InitializeComponent();

            LoadComboBoxData();

            soundIcon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"Images\playSoundIcon.png");

            animalSelected = null;
        }
        private void LoadComboBoxData()
        {
            foreach (string opt in animalOptions)
            {
                animalDropdown.Items.Add(opt);
            }
            animalDropdown.SelectedItem = animalOptions[0];

        }
        private Animal? GenerateAnimalViaName(string name)
        {

            Animal? result = name switch
            {
                COW => new Cow(),
                ROOSTER => new Rooster(),
                HORSE => new Horse(),
                PIG => new Pig(),
                SHEEP => new Sheep(),
                _ => null
            };


            return result;
        }
        private void ChangeAnimalOutput(Animal animal)
        {
            soundIcon.Visible = true;
            playLabel.Visible = true;

            string pathToAnimalImage = AppDomain.CurrentDomain.BaseDirectory + $"Images\\{animal.Photo}";

            animalPicture.Image = Image.FromFile(pathToAnimalImage);

            soundLabel.Text = $"Our Farm Animal, The {animal.Name}, Makes The Sound {animal.SoundAsText}.";
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string selectedName = animalDropdown.SelectedItem?.ToString() ?? "";

            animalSelected = GenerateAnimalViaName(selectedName);

            if (animalSelected is null)
            {
                MessageBox.Show("Unknown Animal Selected!");
                return;
            }

            ChangeAnimalOutput(animalSelected);
        }

        private void soundIcon_Click(object sender, EventArgs e)
        {
            if (animalSelected is null)
            {
                return;
            }

            animalSelected.MakeSound();
        }
    }
}
