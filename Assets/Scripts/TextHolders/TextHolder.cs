
public class TextHolder 
{
    public string StartText;
    public string MovingText;
    public string MovingTextDescription;

    public string WalkingHeader { get; private set; } = "������������";
    public string HelloHeader { get; private set; } = "�����������";
    public virtual void SetText()
    {

    }
}
