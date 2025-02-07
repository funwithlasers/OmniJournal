namespace OmniJournal.Maui.Views;

public partial class TemplatedContentView : ContentView
{
    public static readonly BindableProperty ContentTemplateProperty =
        BindableProperty.Create(
            nameof(ContentTemplate),
            typeof(DataTemplate),
            typeof(TemplatedContentView),
            default(DataTemplate),
            propertyChanged: OnContentTemplateChanged);

    public DataTemplate ContentTemplate
    {
        get => (DataTemplate)GetValue(ContentTemplateProperty);
        set => SetValue(ContentTemplateProperty, value);
    }

    public TemplatedContentView()
    {
        InitializeComponent();
        BindingContextChanged += OnBindingContextChanged; // Listen for BindingContext changes
    }

    private void OnBindingContextChanged(object sender, EventArgs e)
    {
        UpdateContent(); // Refresh when BindingContext changes
    }

    private static void OnContentTemplateChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var view = (TemplatedContentView)bindable;
        view.UpdateContent();
    }

    private void UpdateContent()
    {
        if (ContentTemplate != null && BindingContext != null)
        {
            var content = ContentTemplate.CreateContent() as View;

            if (content != null)
            {
                content.BindingContext = BindingContext;
            }

            // Set the content of the ContentView
            Content = content;
        }
        else
        {
            Content = null;
        }
    }
}