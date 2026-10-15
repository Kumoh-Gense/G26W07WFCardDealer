namespace G26W07WFCardDealer
{
    public partial class Form1 : Form
    {
        private static readonly string[] Suits = ["spades", "hearts", "diamonds", "clubs"];
        private static readonly string[] Values =
            ["ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king"];

        private readonly Random random = new Random();
        private List<int> deck = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // 52장 덱을 만들어 섞는다
        private void ShuffleDeck()
        {
            deck = Enumerable.Range(0, Suits.Length * Values.Length)
                             .OrderBy(_ => random.Next())
                             .ToList();
        }

        // 덱의 맨 위에서 한 장을 뽑아 이미지로 반환한다
        private Image? DrawCard()
        {
            int card = deck[0];
            deck.RemoveAt(0);

            string suit = Suits[card / Values.Length];
            string value = Values[card % Values.Length];

            if (value == "jack" || value == "queen" || value == "king")
            {
                suit += "2";
            }

            return Properties.Resources
                .ResourceManager
                .GetObject($"{value}_of_{suit}") as Image;
        }

        private void OnDeal0(object sender, EventArgs e) => Card1.Image = DrawCard();
        private void Ondeal1(object sender, EventArgs e) => Card2.Image = DrawCard();
        private void Ondeal2(object sender, EventArgs e) => Card3.Image = DrawCard();
        private void Ondeal3(object sender, EventArgs e) => Card4.Image = DrawCard();
        private void Ondeal4(object sender, EventArgs e) => Card5.Image = DrawCard();

        private void Play(object sender, EventArgs e)
        {
            ShuffleDeck();   // 새 게임마다 덱을 다시 섞는다

            OnDeal0(sender, e);
            Ondeal1(sender, e);
            Ondeal2(sender, e);
            Ondeal3(sender, e);
            Ondeal4(sender, e);
        }
    }
}