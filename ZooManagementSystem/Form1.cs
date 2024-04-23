using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ZooManagementSystem
{
    public partial class Form1 : Form
    {

        string[] species = { "Giraffe", "Wolf", "Squirrel Monkey" }; // Array for keeping track of all valid species
        string[] locations = { "Pen 1", "Pen 2", "Pen 3", "Pen 4" }; // Array for keeping track of all locations

        // All new Wolf/Giraffe/SquirrelMonkey objects will be stored in their respective list
        List<Wolf> wolves = new List<Wolf>(); 
        List<Giraffe> giraffes = new List<Giraffe>();
        List<SquirrelMonkey> squirrelMonkeys = new List<SquirrelMonkey>();

        // Variables that various methods require access to.
        string selectedSpecies;
        Wolf activeWolf;
        Giraffe activeGiraffe;
        SquirrelMonkey activeSquirrelMonkey;
        bool nameValid = false;
        bool ageValid = false;
        bool speciesValid = false;
        bool locationValid = false;
        bool sexValid = false;
        string treat = "treats";


        public Form1()
        {
            InitializeComponent();

            /* 
             * Code to create vertical tabs - Copied from the following MS-Learn article:
             * https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-display-side-aligned-tabs-with-tabcontrol?view=netframeworkdesktop-4.8
            */
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

            // Initialize some inital animals for the zoo system to demo features.
            List<Animal> animals = new List<Animal>();
            giraffes.Add(new Giraffe("Wesley", 10, "Male", locations[0]));
            wolves.Add(new Wolf("Ash", 4, "Male", locations[1]));
            squirrelMonkeys.Add(new SquirrelMonkey("Eevee", 12, "Female", locations[2]));

            initializeComboBoxes();
        }

        /*
         * Method initializes the combo boxes to display the all entries 
         * in the species/locations Arrays.
         */
        private void initializeComboBoxes()
        {
            for (int i = 0; i < species.Length; i++)
            {
                comboBoxAddSpecies.Items.Add(species[i]);
                comboBoxSelectSpecies.Items.Add(species[i]);
            }

            for (int i = 0; i < locations.Length; i++)
            {
                comboBoxAddLocation.Items.Add(locations[i]);
            }

        }

        /*
         * Event handler for "Add New Animal" Submit button. Event is used to validate
         * inputs, display errors to user if invalid, and create a new animal derived class
         * if valid.
         */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelSubmitSuccess.Visible = false;

            // Validate Species DropDownList
            if (comboBoxAddSpecies.Text.Length == 0)
            {
                speciesValid = false;
                labelValidationSpecies.Visible = true;
            }
            else
            {
                speciesValid = true;
                labelValidationSpecies.Visible = false;
            }

            // Validate Location DropDownList
            if (comboBoxAddLocation.Text.Length == 0)
            {
                locationValid = false;
                labelValidationLocation.Visible = true;
            }
            else
            {
                locationValid = true;
                labelValidationLocation.Visible = false;
            }

            // Validate Name Field w/ regex (alphabetical characters only)
            if (!(new Regex(@"^[A-Za-z]+$")).IsMatch(textBoxAddName.Text))
            {
                labelValidationName.Visible = true;
                nameValid = false;
            }
            else
            {
                labelValidationName.Visible = false;
                nameValid = true;
            }

            // Validate Age Field w/ reges (digits only)
            if (!(new Regex(@"^\d+$")).IsMatch(textBoxAddAge.Text))
            {
                labelValidationAge.Visible = true;
                ageValid = false;
            }
            else
            {
                labelValidationAge.Visible = false;
                ageValid = true;
            }

            // Validate Sex Radio Choice
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                labelValidationSex.Visible = true;
                sexValid = false;
            }
            else
            {
                labelValidationSex.Visible = false;
                sexValid = true;
            }

            // If All inputs are valid...
            if (speciesValid && locationValid && nameValid && ageValid && sexValid)
            {
                // Initialize variables for class constructors
                string species = comboBoxAddSpecies.Text;
                string name = textBoxAddName.Text;
                int age = Int32.Parse(textBoxAddAge.Text);
                string sex = radioButtonMale.Checked ? "Male" : "Female";
                string location = comboBoxAddLocation.Text;

                // Instanciate the wolf/giraffe/squirrelMonkey depending on species choice.
                if (species == "Wolf")
                {
                    Wolf newWolf = new Wolf(name, age, sex, location);
                    wolves.Add(newWolf);
                    labelSubmitSuccess.Text = $"Wolf \"{name}\" was successfully added to Zoo Manager!";

                }
                if (species == "Giraffe")
                {
                    Giraffe newGiraffe = new Giraffe(name, age, sex, location);
                    giraffes.Add(newGiraffe);
                    labelSubmitSuccess.Text = $"Giraffe \"{name}\" was successfully added to Zoo Manager!";
                }
                if (species == "Squirrel Monkey")
                {
                    SquirrelMonkey newSquirrelMonkey = new SquirrelMonkey(name, age, sex, location);
                    squirrelMonkeys.Add(newSquirrelMonkey);
                    labelSubmitSuccess.Text = $"Squirrel Monkey \"{name}\" was successfully added to Zoo Manager!";
                }

                // After animal is successfully added, reset all fields/dropdowns
                comboBoxAddSpecies.SelectedIndex = -1;
                comboBoxAddLocation.SelectedIndex = -1;
                textBoxAddAge.Clear();
                textBoxAddName.Clear();
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;
                labelSubmitSuccess.Visible = true;
                textBoxTreat.Clear();
            }

        }

        /*
         * Event handler for "View All Animals" page's "Species" dropdown list.
         * It's used to populate/refresh the "Animal" dropdown list with all animals of
         * the selected species.
         */
        private void comboBoxSelectSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reset "Animal" dropdown
            comboBoxSelectAnimal.Items.Clear();
            comboBoxSelectAnimal.Enabled = true;

            // "Animal" dropdown is populated with the relevant animals depending on species selection
            switch (comboBoxSelectSpecies.Text)
            {
                case "Wolf":

                    // set selectedSpecies global var for other methods to reference
                    selectedSpecies = "Wolf";

                    foreach (Wolf wolf in wolves)
                    {
                        comboBoxSelectAnimal.Items.Add(wolf.Name);
                    }
                    break;

                case "Giraffe":

                    // set selectedSpecies global var for other methods to reference
                    selectedSpecies = "Giraffe";

                    foreach (Giraffe giraffe in giraffes)
                    {
                        comboBoxSelectAnimal.Items.Add(giraffe.Name);
                    }
                    break;

                case "Squirrel Monkey":

                    // set selectedSpecies global var for other methods to reference
                    selectedSpecies = "Squirrel Monkey";

                    foreach (SquirrelMonkey squirrelMonkey in squirrelMonkeys)
                    {
                        comboBoxSelectAnimal.Items.Add(squirrelMonkey.Name);
                    }
                    break;
            }

        }

        /*
         * Event handler for "Animal" dropdown list. The selection is used to
         * populate/refresh the info being displayed.
         */
        private void comboBoxSelectAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset action log when new animal is selected
            textBoxActionLog.Clear();

            // Variable used to store the selected animal's name
            string selectedAnimal = comboBoxSelectAnimal.Text;

            /* 
             * Switch case enables/disables interaction buttons depending on wether
             * the species has the interfaces that provide button functionality. For
             * e.g. Giraffe does not have IPlayable & IVocal, so we disable the "Play"
             * and "Vocalize" buttons. Ideally one would programmatically check if a
             * class has implements a specific iterface and then dynamically enable/disable
             * the buttons, but for now this is done manually.
             */
            switch (selectedSpecies)
            {
                case "Wolf":
                    pictureBoxViewPicture.Image = Properties.Resources.wolf;
                    btnPlay.Enabled = true;
                    btnEat.Enabled = true;
                    btnSleep.Enabled = true;
                    btnVocalize.Enabled = true;
                    btnFeed.Enabled = true;

                    // Loop through wolves list to find the selected wolf & populate info text boxes 
                    foreach (Wolf wolf in wolves)
                    {
                        if (wolf.Name == selectedAnimal)
                        {
                            activeWolf = wolf;
                            textBoxViewName.Text = wolf.Name;
                            textBoxViewAge.Text = wolf.Age.ToString();
                            textBoxViewLocation.Text = wolf.Location;
                            textBoxViewSex.Text = wolf.Sex;
                        }

                    }

                    break;

                case "Giraffe": // same as case "wolf" but for giraffes
                    pictureBoxViewPicture.Image = Properties.Resources.giraffe;
                    btnPlay.Enabled = false;
                    btnEat.Enabled = true;
                    btnSleep.Enabled = true;
                    btnVocalize.Enabled = false;
                    btnFeed.Enabled = true;
                    foreach (Giraffe giraffe in giraffes)
                    {
                        if (giraffe.Name == selectedAnimal)
                        {
                            activeGiraffe = giraffe;
                            textBoxViewName.Text = giraffe.Name;
                            textBoxViewAge.Text = giraffe.Age.ToString();
                            textBoxViewLocation.Text = giraffe.Location;
                            textBoxViewSex.Text = giraffe.Sex;
                        }
                    }

                    break;

                case "Squirrel Monkey": // same as case "wolf" but for Squirrel Monkeys
                    pictureBoxViewPicture.Image = Properties.Resources.squirrelmonkey;
                    btnPlay.Enabled = true;
                    btnEat.Enabled = true;
                    btnSleep.Enabled = true;
                    btnVocalize.Enabled = true;
                    btnFeed.Enabled = true;
                    foreach (SquirrelMonkey squirrelMonkey in squirrelMonkeys)
                    {
                        if (squirrelMonkey.Name == selectedAnimal)
                        {
                            activeSquirrelMonkey = squirrelMonkey;
                            textBoxViewName.Text = squirrelMonkey.Name;
                            textBoxViewAge.Text = squirrelMonkey.Age.ToString();
                            textBoxViewLocation.Text = squirrelMonkey.Location;
                            textBoxViewSex.Text = squirrelMonkey.Sex;
                        }
                    }
                    break;

            }
        }

        /*
         * Event handler for feed button. Derived animal's Feed() method is called and passed
         * the treat argument. 
         */
        private void btnFeed_Click(object sender, EventArgs e)
        {
            switch (selectedSpecies)
            {
                case "Wolf":
                    textBoxActionLog.Text = activeWolf.Feed(treat);
                    break;

                case "Giraffe":
                    textBoxActionLog.Text = activeGiraffe.Feed(treat);
                    break;

                case "Squirrel Monkey":
                    textBoxActionLog.Text = activeSquirrelMonkey.Feed(treat);
                    break;


            }
        }

        /*
         * same as above but for Vocalize(). Note that Giraffe doenst 
         * have a Vocalize() as it does not implement that interface.
         */
        private void btnVocalize_Click(object sender, EventArgs e)
        {
            switch (selectedSpecies)
            {
                case "Wolf":
                    textBoxActionLog.Text = activeWolf.Vocalize();
                    break;

                case "Squirrel Monkey":
                    textBoxActionLog.Text = activeSquirrelMonkey.Vocalize();
                    break;


            }
        }

        /*
         * same as above but for Play(). Note that Giraffe doenst 
         * have a Vocalize() as it does not implement that interface.
         */
        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (selectedSpecies)
            {
                case "Wolf":
                    textBoxActionLog.Text = activeWolf.Play();
                    break;

                case "Squirrel Monkey":
                    textBoxActionLog.Text = activeSquirrelMonkey.Play();
                    break;


            }
        }

        /*
         * Same as above but for Eat(). Note that even though all derived classes inherit 
         * an Eat() method, they all override it as well.
         */
        private void btnEat_Click(object sender, EventArgs e)
        {
            switch (selectedSpecies)
            {
                case "Wolf":
                    textBoxActionLog.Text = activeWolf.Eat();
                    break;

                case "Giraffe":
                    textBoxActionLog.Text = activeGiraffe.Eat();
                    break;

                case "Squirrel Monkey":
                    textBoxActionLog.Text = activeSquirrelMonkey.Eat();
                    break;


            }
        }

        /*
         * Same as above but for Sleep(). Note that since we pass the animal's
         * location property as an argument, the derived class's Sleep() method
         * is used. Without an argument it would default to the base class's method
         */
        private void btnSleep_Click(object sender, EventArgs e)
        {
            switch (selectedSpecies)
            {
                case "Wolf":
                    textBoxActionLog.Text = activeWolf.Sleep(activeWolf.Location);
                    break;

                case "Giraffe":
                    textBoxActionLog.Text = activeGiraffe.Sleep(activeGiraffe.Location);
                    break;

                case "Squirrel Monkey":
                    textBoxActionLog.Text = activeSquirrelMonkey.Sleep(activeSquirrelMonkey.Location);
                    break;


            }
        }

        // Change treat variable value to the textBox's text. Defaults to "treats" text box is empty.
        private void textBoxTreat_TextChanged(object sender, EventArgs e)
        {
            treat = textBoxTreat.Text.Length > 0 ? textBoxTreat.Text : "treats";
        }

        // Code to create vertical tabs - taken from MS.Learn article
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.SteelBlue, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
}
