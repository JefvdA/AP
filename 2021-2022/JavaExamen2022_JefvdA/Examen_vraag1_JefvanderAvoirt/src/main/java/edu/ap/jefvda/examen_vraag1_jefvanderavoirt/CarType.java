package edu.ap.jefvda.examen_vraag1_jefvanderavoirt;

public enum CarType {
    SUV,
    BREAK,
    SEDAN,
    HATCHBACK,
    SPORT;

    public static CarType fromInt(int x){
        switch (x){
            case 0:
                return SUV;
            case 1:
                return BREAK;
            case 2:
                return SEDAN;
            case 3:
                return HATCHBACK;
            case 4:
                return SPORT;
            default:
                return null;
        }
    }
}
