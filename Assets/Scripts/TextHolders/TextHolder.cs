
public class TextHolder 
{
    public string StartTextDescription;
    public string MovingTextDescription;
    public string MovingTextAction1;
    public string MovingTextAction2;
    public string ActionTextDescription;
    public string ActionTextAction;
    public string GrabTextDescription;
    public string GrabTextAction;
    public string IconTextDescription;
    public string IconTextAction;
    public string MultiIconTextDescription;
    public string MultiIconTextAction;

    public string WalkingHeader { get; private set; } = "������������";
    public string HelloHeader { get; private set; } = "�����������";
    public string ActionHeader { get; private set; } = "�������������� � ����������";
    public string GrabHeader { get; private set; } = "���� ���������";
    public string IconHeader { get; private set; } = "�������������� � ��������";
    public string MultiIconHeader { get; private set; } = "�������� � ����������� ��������";
    public virtual void SetText()
    {

    }
}
