namespace RichTextBlockExample
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            string output = "Testing <bold>formatted</bold> text <underline>with</underline> a <italic>textblock</italic>";
            TextBlockUsingBehaviour.Text = output;
            TextBlockUsingAttachedProperty.SetValue(SupportRichText.RichTextProperty, output);
        }
    }
}