using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ZooManagementSystem
{
    public partial class Form1 : Form
    {
        string[] species = { "Giraffe", "Wolf", "Squirrel Monkey" };
        string[] locations = { "Pen 1", "Pen 2", "Pen 3", "Pen 4" };
        List<Wolf> wolves = new List<Wolf>();
        List<Giraffe> giraffes = new List<Giraffe>();
        List<SquirrelMonkey> squirrelMonkeys = new List<SquirrelMonkey>();
        string selectedSpecies;
        Wolf activeWolf;
        Giraffe activeGiraffe;
        SquirrelMonkey activeSquirrelMonkey;
        bool nameValid = false;
        bool ageValid = false;
        bool speciesValid = false;
        bool locationValid = false;
        bool sexValid = false;


        public Form1()
        {
            InitializeComponent();
            // Code to create vertical tabs
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

            giraffes.Add(new Giraffe("Wesley", 10, "Male", locations[0]));
            wolves.Add(new Wolf("Ash", 4, "Male", locations[1]));
            squirrelMonkeys.Add(new SquirrelMonkey("Eevee", 12, "Female", locations[2]));


            initializePageAddAnimals();
            initializePageViewAnimals();


        }

        private void initializePageAddAnimals()
        {
            for (int i = 0; i < species.Length; i++)
            {
                comboBoxAddSpecies.Items.Add(species[i]);
            }

            for (int i = 0; i < locations.Length; i++)
            {
                comboBoxAddLocation.Items.Add(locations[i]);
            }

        }

        private void initializePageViewAnimals()
        {
            for (int i = 0; i < species.Length; i++)
            {
                comboBoxSelectSpecies.Items.Add(species[i]);
            }
        }



        // Code to create vertical tabs
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            labelSubmitSuccess.Visible = false;

            if (comboBoxAddSpecies.Text.Length == 0)
            {
                speciesValid = false;
                labelValidationSpecies.Visible = true;
            } else
            {
                speciesValid = true;
                labelValidationSpecies.Visible = false;
            }

            if (comboBoxAddLocation.Text.Length == 0)
            {
                locationValid = false;
                labelValidationLocation.Visible = true;
            } else
            {
                locationValid = true;
                labelValidationLocation.Visible = false;
            }

            if (!(new Regex(@"^[A-Za-z]+$")).IsMatch(textBoxAddName.Text))
            {
                labelValidationName.Visible = true;
                nameValid = false;
            } else
            {
                labelValidationName.Visible = false;
                nameValid = true;
            }

            if (!(new Regex(@"^\d+$")).IsMatch(textBoxAddAge.Text))
            {
                labelValidationAge.Visible = true;
                ageValid = false;
            } else
            {
                labelValidationAge.Visible = false;
                ageValid = true;
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                labelValidationSex.Visible = true;
                sexValid = false;
            } else
            {
                labelValidationSex.Visible = false;
                sexValid = true;
            }

            if (speciesValid && locationValid && nameValid && ageValid && sexValid)
            {
                string species = comboBoxAddSpecies.Text;
                string name = textBoxAddName.Text;
                int age = Int32.Parse(textBoxAddAge.Text);
                string sex = "Unspecified";
                string location = comboBoxAddLocation.Text;
                if (radioButtonMale.Checked)
                {
                    sex = "Male";
                }
                else if (radioButtonFemale.Checked)
                {
                    sex = "Female";
                }

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

                comboBoxAddSpecies.SelectedIndex = -1;
                comboBoxAddLocation.SelectedIndex = -1;
                textBoxAddAge.Clear();
                textBoxAddName.Clear();
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = false;
                labelSubmitSuccess.Visible = true;
            }

        }

        private void comboBoxSelectSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectAnimal.Items.Clear();
            comboBoxSelectAnimal.Enabled = true;
            if (comboBoxSelectSpecies.Text == "Wolf")
            {
                selectedSpecies = "Wolf";

                foreach (Wolf wolf in wolves)
                {
                    comboBoxSelectAnimal.Items.Add(wolf.Name);
                }
            }

            if (comboBoxSelectSpecies.Text == "Giraffe")
            {
                selectedSpecies = "Giraffe";
                foreach (Giraffe giraffe in giraffes)
                {
                    comboBoxSelectAnimal.Items.Add(giraffe.Name);
                }
            }

            if (comboBoxSelectSpecies.Text == "Squirrel Monkey")
            {
                selectedSpecies = "Squirrel Monkey";
                foreach (SquirrelMonkey squirrelMonkey in squirrelMonkeys)
                {
                    comboBoxSelectAnimal.Items.Add(squirrelMonkey.Name);
                }
            }

        }

        private void comboBoxSelectAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxActionLog.Clear();
            string selectedAnimal = comboBoxSelectAnimal.Text;
            switch (selectedSpecies)
            {
                case "Wolf":
                    pictureBoxViewPicture.Image = Image.FromFile("./Assets/wolf.jpg");
                    btnPlay.Enabled = true;
                    btnEat.Enabled = true;
                    btnSleep.Enabled = true;
                    btnVocalize.Enabled = true;
                    btnFeed.Enabled = true;
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

                case "Giraffe":
                    pictureBoxViewPicture.Image = Image.FromFile("./Assets/giraffe.jpg");
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

                case "Squirrel Monkey":
                    pictureBoxViewPicture.Image = Image.FromFile("./Assets/squirrelmonkey.jpg");
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

        private void btnFeed_Click(object sender, EventArgs e)
        {
            switch (selectedSpecies)
            {
                case "Wolf":
                    textBoxActionLog.Text = activeWolf.Feed();
                    break;

                case "Giraffe":
                    textBoxActionLog.Text = activeGiraffe.Feed();
                    break;

                case "Squirrel Monkey":
                    textBoxActionLog.Text = activeSquirrelMonkey.Feed();
                    break;


            }
        }

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

        private void btnSleep_Click(object sender, EventArgs e)
        {
            switch (selectedSpecies)
            {
                case "Wolf":
                    textBoxActionLog.Text = activeWolf.Sleep();
                    break;

                case "Giraffe":
                    textBoxActionLog.Text = activeGiraffe.Sleep();
                    break;

                case "Squirrel Monkey":
                    textBoxActionLog.Text = activeSquirrelMonkey.Sleep();
                    break;


            }
        }

    }
}
