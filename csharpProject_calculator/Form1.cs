
using System;
using System.Collections.Generic;
using Expression = org.mariuszgromada.math.mxparser.Expression;

namespace csharpProject_calculator
{
    public partial class Form1 : Form
    {
        //fonction_speciales_label : represente la liste des fonctions auxquelles une paranthese sera ajouté de maniere automatique 
        private readonly List<string> fonction_speciales_label = new() { "tan", "cos", "sin", "√", "log", "ln", "deg", "rad" };
        List<string> liste_separateurs = new() { "+", "-", "/", "x", "(", "^" };

        //fonction_speciales : represente la liste des separateurs dans le calcul saisie par l'utilisateur
        // le calcul saisie par l'utilisateur sera decouper en fonctions de ceux-ci
        /*Dictionary<string, string> fonction_speciales = new()
        {

            { "sqrt", "sqrt" },
            { "log", "log" },
            { "ln", "log" },
            { "!", "factorial" },
            { "x^y", "pow" },
            { "pi", "pi" }
        };*/

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Parcour la calcul saisie par l'utilisateur et le decoupe en fonction de la liste "fonction_speciales" definit plus haut.
        /// Chaque caractere sera concatené a une variable intermediare "terme" tant qu'un separateur n'est pas rencontré.
        /// Si celui-ci l'est, la variable "terme" sera ajoutée dans une liste nommée "operations_termes" de même que le separateur.
        /// </summary>
        /// <returns>Calculate() "0" ou "Resultat"</returns>
        public double Verif_expression()
        {
            Console.WriteLine("Hello");
            List<string> operations_termes = new() { };

            string valeur_saisie = screenCalculator.Text;
            string terme = "";
            foreach (var item in valeur_saisie)
            {
                string item2 = item.ToString();
                //MessageBox.Show(item2);
                if (!liste_separateurs.Contains(item2))
                {
                    terme += item2;
                }
                else
                {
                    operations_termes.Add(terme);
                    operations_termes.Add(item2);
                    terme = "";
                }

            }
            operations_termes.Add(terme);

            //Console.WriteLine("Debut du parcours");

            //Concatene tous les elements de la liste pour obtenir une chaine de caracteres qui sera notre expressions mathematique a calculer
            string operation = "";
            foreach (var item in operations_termes)
            {
                operation += item;
            }
            operation = operation.Replace("x", "*");
            operation = operation.Replace("log", "log10");
            return calculate(operation);
        }
        /// <summary>
        /// Calcul l'operation saisie par l'utilisateur
        /// </summary>
        /// <param name="operation"></param>
        /// <returns>0 S'il y a une erreur dans l'expression saisie sinon le resultat</returns>
        public double calculate(string operation)
        {
            // Expression mathématique à évaluer
            //string expressionString = screenCalculator.Text;
            double resultat = 0.0;
            // Créer une instance de l'objet Expression qui fera le calcul
            Expression expression = new(operation);

            // Évaluer l'expression
            //expression.checkSyntax(): verifie la syntaxe 
            /*
             * !liste_separateurs.Contains(operation[operation.Length - 1].ToString() : 
             * Permet de mieux securiser la verification car "expression.checkSyntax()" laisse passer les expressions
             * du type "x+", "x-", "x*", etc. x etant une valeur saisie
             * */
            if (expression.checkSyntax() && !liste_separateurs.Contains(operation[operation.Length - 1].ToString()))
            {

                resultat = expression.calculate();
                afficheResultat(resultat.ToString());

                //MessageBox.Show($"Résultat de l'expression : {resultat}");
            }
            else
            {
                afficheResultat(" ");
                return 0;

            }
            //MessageBox.Show($"Résultat de l'expression : {result}");

            /*try
            {
                // Évaluer l'expression
                object result = expression.Evaluate();
                MessageBox.Show($"Résultat de l'expression : {result}");
            }
            catch (NCalc.EvaluationException ex)
            {
                MessageBox.Show($"Erreur d'évaluation : {ex.Message}");
            }*/
            return resultat;
        }

        /// <summary>
        /// Affiche le resultat du calcul apres un saut de ligne representé par "\r\n"
        /// </summary>
        /// <param name="resultat">Resultat de l'operation saisie par l'utilisateur</param>
        public void afficheResultat(string resultat)
        {
            screenResultat.Text = " ";
            screenResultat.Text += "\r\n";
            screenResultat.Text += resultat;
        }

        /// <summary>
        /// Constitue un evenement commun a tous les boutons.
        /// 
        /// </summary>
        /// <param name="sender">Represente l'objet qui a declenché l'evenement</param>
        /// <param name="e"></param>
        private void boutton_CLick(object sender, EventArgs e)
        {
            // Cast du sender en Button pour obtenir des informations sur le bouton cliqué
            Button boutonClique = (Button)sender;


            // Vérification pour éviter les erreurs si le cast n'a pas réussi
            if (boutonClique != null)
            {
                // Obtenez la valeur du bouton (par exemple, son texte ou son nom)
                string valeurBouton = boutonClique.Text;

                //Recupere la position du curseur
                int cursorPosition = screenCalculator.SelectionStart;
                switch (valeurBouton)
                {
                    case "=":
                        // Angle en degrés

                        // Convertir l'angle en radians
                        //double angleRadians = (angleDegrees*Math.PI)/180;

                        double verif_resultat = Verif_expression();
                        if (verif_resultat == 0)
                        {
                            afficheResultat("Erreur de syntaxe");
                        }

                        //Permet de maintenir la position du curseur sinon, elle retournera a son etat initial. C'est-a-dire "0".
                        screenCalculator.SelectionStart = cursorPosition;
                        break;

                    case "AC":
                        //Vide les differents champs
                        screenCalculator.Clear();
                        screenResultat.Clear();
                        break;

                    case "DEL":
                        //MessageBox.Show("Cursor : " + cursorPosition + " Text len : " + screenCalculator.Focused);
                        //screenCalculator.Text = screenCalculator.Text.Substring(cursorPosition, screenCalculator.Text.Length - 1);
                        //int saveCursorPosition = cursorPosition;
                        try
                        {
                            screenCalculator.Text = screenCalculator.Text.Substring(0, cursorPosition - 1);
                        }
                        catch
                        {
                            screenCalculator.Text = screenCalculator.Text.Substring(0, cursorPosition);
                        }
                        screenCalculator.SelectionStart = cursorPosition;

                        Verif_expression();
                        break;

                    case "close":
                        Application.Exit();
                        break;

                    default:

                        // Faites quelque chose avec la valeur du bouton, par exemple, l'afficher dans une MessageBox
                        //MessageBox.Show("Bouton cliqué : " + valeurBouton);
                        if (fonction_speciales_label.Contains(valeurBouton))
                        {
                            valeurBouton = valeurBouton + "(";
                        }
                        else if (valeurBouton == "x^y")
                        {
                            valeurBouton = "^(";
                        }
                        screenCalculator.Text = screenCalculator.Text.Insert(cursorPosition, valeurBouton);
                        // Définissez la nouvelle position du curseur 
                        screenCalculator.SelectionStart = cursorPosition + valeurBouton.Length;

                        /*//valeurBouton = fonction_speciales_label.Contains(valeurBouton) ? valeurBouton + "(" : valeurBouton;
                        if (screenCalculator.Text.Length <= 0)
                        {
                            screenCalculator.Text = screenCalculator.Text.Insert(cursorPosition, valeurBouton);
                            // Définissez la nouvelle position du curseur
                            screenCalculator.SelectionStart = cursorPosition + valeurBouton.Length;

                        }else
                        {
                            //string lastCharacter = screenCalculator.Text[screenCalculator.Text.Length - 1].ToString();
                            //MessageBox.Show("LastChar : " + lastCharacter+" Valeur du bouton : "+valeurBouton);
                            *//*if (!liste_separateurs.Contains(lastCharacter) && !liste_separateurs.Contains(valeurBouton))
                            {*//*
                            screenCalculator.Text = screenCalculator.Text.Insert(cursorPosition, valeurBouton);
                            // Définissez la nouvelle position du curseur
                            screenCalculator.SelectionStart = cursorPosition + valeurBouton.Length;

                            //}
                        }*/

                        // Définissez la sélection du texte
                        //screenCalculator.SelectionLength = 0;
                        Verif_expression();

                        break;


                }
            }
        }

        private void screenCalculator_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
