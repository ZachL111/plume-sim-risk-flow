using PlumeSimRiskFlow;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(46, 49, 16, 51);
        if (DomainReviewLens.Score(item) != 144) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
