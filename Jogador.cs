namespace AulaPOOConstrutor
{
    public class Jogador
    {
        public string Nome { get; set; }
        public float Altura { get; set; }
        public string Posicao { get; set; }
        public int Velocidade { get; set; }
        public int PuloVertical { get; set; }
        public int Arremesso { get; set; }
        public int Finalizacao { get; set; }
        public int Controle { get; set; }
        public int Passe { get; set; }
        public int Defesa { get; set; }
        public int Rebote { get; set; }

        public Jogador(string _nome, float _altura, string _posicao, int _velocidade, int _pulo, int _arremesso, int _finalizacao, int _controle, int _passe, int _defesa, int _rebote) {
            this.Nome = _nome;
            this.Altura = _altura;
            this.Posicao = _posicao;
            this.Velocidade = _velocidade;
            this.PuloVertical = _pulo;
            this.Arremesso = _arremesso;
            this.Finalizacao = _finalizacao;
            this.Controle = _controle;
            this.Passe = _passe;
            this.Defesa = _defesa;
            this.Rebote = _rebote;
        }


    }
}