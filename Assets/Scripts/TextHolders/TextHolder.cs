
public class TextHolder 
{
    public string StartText;
    public string MovingText;
    public string MovingTextDescription1;
    public string MovingTextDescription2;

    public string WalkingHeader { get; private set; } = "������������";
    public string HelloHeader { get; private set; } = "�����������";
    public virtual void SetText()
    {

    }
}
