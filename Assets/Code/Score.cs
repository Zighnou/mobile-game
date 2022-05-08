static class Score{
    static int score = 0;

    public static int getScore(){
        return score;
    }

    public static void incrScore(int incrVal){
        score += incrVal;
    }
}