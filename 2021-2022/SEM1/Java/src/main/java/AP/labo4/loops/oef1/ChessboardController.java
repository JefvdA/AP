package AP.labo4.loops.oef1;

public class ChessboardController {
    public static void main(String[] args) {
        printChessboard();
    }

    static void printChessboard(){
        for (int i = 0; i < 8; i++){
            for (int j = 0; j < 8; j++){
                int cell = (i+j)%2;
                if(cell == 0)
                    System.out.printf("%c", 0x25A0);
                else
                    System.out.printf("%c", 0x25A1);
            }
            System.out.print("\n");
        }
    }
}
