/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package flyweightpattern;

/**
 *
 * @author TIENIT
 */
public class StudentThreaded {

    /**
     * @return the averageScore
     */
    public double getAverageScore() {
        return averageScore;
    }

    /**
     * @param averageScore the averageScore to set
     */
    public void setAverageScore(double averageScore) {
        this.averageScore = averageScore;
    }
    
    /**
     * @return the name
     */
    public String getName() {
        return name;
    }

    /**
     * @param name the name to set
     */
    public void setName(String name) {
        this.name = name;
    }

    /**
     * @return the id
     */
    public int getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(int id) {
        this.id = id;
    }

    /**
     * @return the score
     */
    public int getScore() {
        return score;
    }

    /**
     * @param score the score to set
     */
    public void setScore(int score) {
        this.score = score;
    }
    
    private String name;
    private int id;
    private int score;
    private double averageScore;
    private static StudentThreaded singleObject = new StudentThreaded();
    
    private StudentThreaded() {
    }
    
    public double getStanding() {
        return (((double) score) / getAverageScore() - 1.0) * 100.0;
    }
    
    public static StudentThreaded getInstance() {
        return singleObject;
    }
            
}
