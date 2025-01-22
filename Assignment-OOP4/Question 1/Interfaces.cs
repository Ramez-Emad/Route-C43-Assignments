namespace Assignment_OOP4.Question_1
{
    internal interface Ishape
    {
        double Area { get; set; }
        void DisplayShapeInfo();
    }

    internal interface Icircle : Ishape
    {
        double Radius { get; set; }
    }

    internal interface Irectangle : Ishape
    {
        double Length { get; set; }
        double Width { get; set; }
    }
}
