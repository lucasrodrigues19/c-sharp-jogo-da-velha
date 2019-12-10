using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        string[ , ]posicao = new string[3,3];
        string vezJogador="";
        string vencedor = "";
        int cX, cO;
        public Form1()
        {
            InitializeComponent();
            lbl_l0c0.ResetText();
            lbl_l0c1.ResetText();
            lbl_l0c2.ResetText();
            lbl_l1c0.ResetText();
            lbl_l1c1.ResetText();
            lbl_l1c2.ResetText();
            lbl_l2c0.ResetText();
            lbl_l2c1.ResetText();
            lbl_l2c2.ResetText();
            lbl_vencedor.ResetText();
            cX = 0;
            cO = 0;
            for(int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 3; c++)
                {
                    posicao[l, c] = "";
                }
               
            }
        }

        #region linha 2
        private void Jp_l2c0_MouseClick(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l2c0");
        }

        private void Jp_l2c1_MouseClick(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l2c1");
        }

        private void Jp_l2c2_MouseClick(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l2c2");
        }
        #endregion

        #region linha 1
        private void Jp_l1c0_MouseClick(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l1c0");
        }

        private void Jp_l1c1_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l1c1");
        }

        private void Jp_l1c2_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l1c2");
        }
        #endregion

        #region linha 0
        private void Jp_l0c0_MouseClick(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l0c0");
        }

        private void Jp_l0c1_MouseClick(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l0c1");
        }

        private void Jp_l0c2_MouseClick(object sender, MouseEventArgs e)
        {
            this.jogoDaVelha("l0c2");
        }
        #endregion

        #region metodosEspeciais
        public void setVezJogador(String vez)
        {
            if (vezJogador.Equals(""))
            {
                
                if (vez == "X")
                {
                    this.jp_X.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.jp_O.BackColor = System.Drawing.SystemColors.Control;
                }
                else if (vez == "O")
                {
                    this.jp_O.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.jp_X.BackColor = System.Drawing.SystemColors.Control;
                }
                vezJogador = vez;
                lbl_vencedor.Text = "vez de " + vezJogador;
                for (int l = 0; l < 3; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        posicao[l, c] = "";
                    }
                }
                lbl_l0c0.ResetText();
                lbl_l0c1.ResetText();
                lbl_l0c2.ResetText();
                lbl_l1c0.ResetText();
                lbl_l1c1.ResetText();
                lbl_l1c2.ResetText();
                lbl_l2c0.ResetText();
                lbl_l2c1.ResetText();
                lbl_l2c2.ResetText();
                gp_opcao.Text = "PLACAR:";
                vencedor = "";
            }
        }
        public void vezJogadorM()
        {
            if (vencedor.Equals(""))
            {
                
               if(posicao[0, 0] != "" && posicao[0, 1] != "" && posicao[0, 2]!="" &&
                 posicao[1, 0] != "" && posicao[1, 1] != "" && posicao[1, 2] != "" &&
                 posicao[2, 0] != "" && posicao[2, 2] != "" && posicao[2, 2] != "")
                {
                 lbl_vencedor.Text = "Empate";
                    for (int l = 0; l < 3; l++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            posicao[l, c] = "ganhou";
                        }
                    }
                    vezJogador = "";
                    lbl_vencedor.Text += "\n selecione X ou O para continuar";

                }
                else
                {
                    if (vezJogador == "X")
                    {
                        this.jp_X.BackColor = System.Drawing.SystemColors.AppWorkspace;
                        this.jp_O.BackColor = System.Drawing.SystemColors.Control;

                    }
                    else if (vezJogador == "O")
                    {
                        this.jp_O.BackColor = System.Drawing.SystemColors.AppWorkspace;
                        this.jp_X.BackColor = System.Drawing.SystemColors.Control;
                    }

                    lbl_vencedor.Text = "vez de " + vezJogador;
                }
                    
                
                
                
            }
            else
            {
                if(vencedor.Equals("Jogador X venceu"))
                {
                    cX++;
                    lbl_X.Text = cX.ToString();
                }
                else if(vencedor.Equals("Jogador O venceu"))
                {
                    cO++;
                    lbl_O.Text = cO.ToString();
                }
                else
                {

                }
               for(int l = 0; l < 3; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        posicao[l, c] = "ganhou";
                    }
                }
                vezJogador = "";
                lbl_vencedor.Text += "\n selecione X ou O para continuar";
                
            }
        
        }
    
       public void reniciar()
        {
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    posicao[l, c] = "";
                }
            }
            cX = 0;
            cO = 0;
            vezJogador = "";
            this.jp_X.BackColor = System.Drawing.SystemColors.Control;
            this.jp_O.BackColor = System.Drawing.SystemColors.Control;
            lbl_l0c0.ResetText();
            lbl_l0c1.ResetText();
            lbl_l0c2.ResetText();
            lbl_l1c0.ResetText();
            lbl_l1c1.ResetText();
            lbl_l1c2.ResetText();
            lbl_l2c0.ResetText();
            lbl_l2c1.ResetText();
            lbl_l2c2.ResetText();
            lbl_X.Text = "_";
            lbl_O.Text = "_";
            lbl_vencedor.ResetText();
            gp_opcao.Text = "ESCOLHA UMA OPÇÃO: ";
            vencedor = "";

        }
        public void jogoDaVelha(string jogada)
        {
            switch (jogada)
            {
                #region jogoVelha_linha0

               
                case "l0c0":
                   
                    if (posicao[0, 0].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[0, 0] = vezJogador;
                            lbl_l0c0.Text = posicao[0,0];
                            vezJogador = "O";

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }

                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[0, 0] = vezJogador;
                            lbl_l0c0.Text = posicao[0, 0];
                            vezJogador = "X";

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                        }
                        this.vezJogadorM();
                    }
                    
                    break;
                case "l0c1":
                    if (posicao[0, 1].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[0, 1] = vezJogador;
                            lbl_l0c1.Text = posicao[0, 1];
                            vezJogador = "O";
                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }

                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[0, 1] = vezJogador;
                            lbl_l0c1.Text = posicao[0, 1];
                            vezJogador = "X";
                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                        }
                        this.vezJogadorM();
                    }
                 
                    break;
                case "l0c2":
                    if (posicao[0, 2].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[0, 2] = vezJogador;
                            lbl_l0c2.Text = posicao[0, 2];
                            vezJogador = "O";
                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }


                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[0, 2] = vezJogador;
                            lbl_l0c2.Text = posicao[0, 2];
                            vezJogador = "X";

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                        }
                        this.vezJogadorM();
                    }
                    
                    break;
                #endregion
                   #region jogoVelha_linha1
                case "l1c0":

                    if (posicao[1, 0].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[1, 0] = vezJogador;
                            lbl_l1c0.Text = posicao[1, 0];
                            vezJogador = "O";

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[1, 0] = vezJogador;
                            lbl_l1c0.Text = posicao[1, 0];
                            vezJogador = "X";

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                        }
                        this.vezJogadorM();
                    }
                 
                    break;
                case "l1c1":

                    if (posicao[1, 1].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[1, 1] = vezJogador;
                            lbl_l1c1.Text = posicao[1, 1];
                            vezJogador = "O";

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }

                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[1, 1] = vezJogador;
                            lbl_l1c1.Text = posicao[1, 1];
                            vezJogador = "X";

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                        }
                        this.vezJogadorM();
                    }
                   
                    break;
                case "l1c2":

                    if (posicao[1, 2].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[1, 2] = vezJogador;
                            lbl_l1c2.Text = posicao[1, 2];
                            vezJogador = "O";

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }

                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[1, 2] = vezJogador;
                            lbl_l1c2.Text = posicao[1, 2];
                            vezJogador = "X";


                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                        }
                        this.vezJogadorM();
                    }
                   
                    break;
                #endregion
                #region jogoVelha_linha2
                case"l2c0":
                    if (posicao[2, 0].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[2, 0] = vezJogador;
                            lbl_l2c0.Text = posicao[2, 0];
                            vezJogador = "O";
                           


                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            
                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[2, 0] = vezJogador;
                            lbl_l2c0.Text = posicao[2, 0];
                            vezJogador = "X";
                           
                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }

                            
                        }
                        this.vezJogadorM();
                    }
                   
                    break;
                case "l2c1":
                    if (posicao[2, 1].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[2, 1] = vezJogador;
                            lbl_l2c1.Text = posicao[2, 1];
                            vezJogador = "O";
                            


                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            
                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[2, 1] = vezJogador;
                            lbl_l2c1.Text = posicao[2, 1];
                            vezJogador = "X";
                            

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                         
                        }
                        this.vezJogadorM();
                    }
                    break;
                case "l2c2":
                    if (posicao[2, 2].Equals("") && !vezJogador.Equals(""))
                    {
                        if (vezJogador.Equals("X"))
                        {
                            posicao[2, 2] = vezJogador;
                            lbl_l2c2.Text = posicao[2, 2];
                            vezJogador = "O";
                            


                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("X") && posicao[l, 1].Equals("X") && posicao[l, 2].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("X") && posicao[1, l].Equals("X") && posicao[2, l].Equals("X"))
                                {
                                    vencedor = "Jogador X venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 0].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("X") && posicao[1, 1].Equals("X") && posicao[2, 2].Equals("X"))
                            {
                                vencedor = "Jogador X venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                           

                        }
                        else if (vezJogador.Equals("O"))
                        {
                            posicao[2, 2] = vezJogador;
                            lbl_l2c2.Text = posicao[2, 2];
                            vezJogador = "X";
                        

                            for (int l = 0; l < 3; l++)
                            {
                                //trava a linha e verifica as colunas
                                if (posicao[l, 0].Equals("O") && posicao[l, 1].Equals("O") && posicao[l, 2].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }
                                //trava a coluna e verifica as linhas
                                if (posicao[0, l].Equals("O") && posicao[1, l].Equals("O") && posicao[2, l].Equals("O"))
                                {
                                    vencedor = "Jogador O venceu";
                                    lbl_vencedor.Text = vencedor;
                                }

                            }
                            if (posicao[0, 2].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 0].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            if (posicao[0, 0].Equals("O") && posicao[1, 1].Equals("O") && posicao[2, 2].Equals("O"))
                            {
                                vencedor = "Jogador O venceu";
                                lbl_vencedor.Text = vencedor;
                            }
                            
                        }
                        this.vezJogadorM();
                    }
                    break;
                    #endregion
            }

        }





        #endregion

        private void Jp_O_MouseClick(object sender, MouseEventArgs e)
        {
            this.setVezJogador("O");
        }

        private void Jp_X_MouseClick(object sender, MouseEventArgs e)
        {
            this.setVezJogador("X");
        }

        private void Lbl_l0c0_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.reniciar();
        }
    }
}
