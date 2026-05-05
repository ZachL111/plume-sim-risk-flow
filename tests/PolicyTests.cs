using PlumeSimRiskFlow;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(80, 73, 23, 25, 5);
        if (Policy.Score(signalcase_1) != 46) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(96, 81, 18, 18, 6);
        if (Policy.Score(signalcase_2) != 147) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(69, 74, 8, 23, 7);
        if (Policy.Score(signalcase_3) != 107) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
