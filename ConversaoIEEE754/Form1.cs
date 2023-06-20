using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversaoIEEE754
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEscrita1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        byte[] FloatTo16BitFixedPoint(float number, float scaleFactor = 130)
        {
            // Multiplica o número pelo fator de escala
            number *= scaleFactor;

            // Arredonda o número para o inteiro mais próximo
            short fixedPointNumber = (short)Math.Round(number);

            // Converte o valor para um array de bytes
            byte[] bytes = BitConverter.GetBytes(fixedPointNumber);
    
            // Inverte a ordem dos bytes no array
            Array.Reverse(bytes);

            // Retorna o array de bytes
            return bytes;
        }
    
        float FixedPoint16BitToFloatBigEndian(byte[] bytes, float scaleFactor = 130)
        {
            // Converte os bytes para um valor inteiro de 16 bits sem precisar inverter a ordem
            short fixedPointNumber = (short)((bytes[0] << 8) | bytes[1]);

            // Divide o valor pelo fator de escala para obter o valor de ponto flutuante
            float number = fixedPointNumber / scaleFactor;

            return number;
        }

        private void btnEscrever_Click(object sender, EventArgs e)
        {
            float teste = float.Parse(txtEscritaFloat.Text);
            byte[] bytesEscrita = FloatTo16BitFixedPoint(teste, 130);
            txtByteEscrita.Text = BitConverter.ToString(bytesEscrita);
            txtEscritaByte1.Text = bytesEscrita[0].ToString();
            txtEscritaByte2.Text = bytesEscrita[1].ToString();
        }

        private void btnLeitura_Click(object sender, EventArgs e)
        {
            string string_byte1 = txtLeituraByte1.Text;
            string string_byte2 = txtLeituraByte2.Text;
            byte byte1 = Convert.ToByte(string_byte1, 16);
            byte byte2 = Convert.ToByte(string_byte2, 16);
            byte[] bytes_array = new byte[] { byte1, byte2 };
            float resultado_leitura = FixedPoint16BitToFloatBigEndian(bytes_array, 130);
            txtLeituraFloat.Text = resultado_leitura.ToString();
        }
    }
    
    
}