package edu.ap.demo;

import javafx.application.Application;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.TextField;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Box;
import javafx.scene.shape.Circle;
import javafx.scene.text.Font;
import javafx.scene.text.Text;
import javafx.scene.transform.Rotate;
import javafx.scene.transform.Translate;
import javafx.stage.Stage;

import java.io.FileInputStream;
import java.io.FileNotFoundException;

public class JavaFxExample extends Application {
    @Override
    public void start(Stage stage) throws Exception {
        drawCircle(stage);
    }

    private void drawCircle(Stage stage){
        Circle circle = new Circle();

        circle.setCenterX(200.0f);
        circle.setCenterY(180.0f);
        circle.setRadius(90.0f);
        circle.setFill(Color.MAGENTA);

        Text text = new Text("This is a colored circle");

        text.setFont(Font.font("Edwardian Script ITC", 50));

        text.setX(55);
        text.setY(50);

        Group root = new Group(circle, text);

        Scene scene = new Scene(root, 600, 300);

        stage.setTitle("Image pattern Example");

        stage.setScene(scene);

        stage.show();

        EventHandler<MouseEvent> eventHandler = new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent mouseEvent) {
                System.out.println("Hello world!");
                circle.setFill(Color.DARKSLATEBLUE);
            }
        };
        circle.addEventHandler(MouseEvent.MOUSE_CLICKED, eventHandler);
    }

    private void drawCube(Stage stage){
        Box box = new Box();

        box.setWidth(150.0);
        box.setHeight(150.0);
        box.setDepth(150.0);
        box.setLayoutX(150.0);
        box.setLayoutY(150.0);

        Translate translate = new Translate();
        translate.setX(100);
        translate.setY(50);
        translate.setZ(25);

        Rotate rxBox = new Rotate(0, 0, 0, 0, Rotate.X_AXIS);
        Rotate ryBox = new Rotate(0, 0, 0, 0, Rotate.Y_AXIS);
        Rotate rzBox = new Rotate(0, 0, 0, 0, Rotate.Z_AXIS);
        rxBox.setAngle(30);
        ryBox.setAngle(50);
        rzBox.setAngle(30);
        box.getTransforms().addAll(translate, rxBox, ryBox, rzBox);

        Group root = new Group(box);

        Scene scene = new Scene(root, 600, 600);

        stage.setTitle("Drawing a Cube");

        stage.setScene(scene);

        stage.show();
    }

    private void drawImage(Stage stage){
        Image image;
        try {
            image = new Image(new FileInputStream("AP.png"));

            ImageView imageView = new ImageView(image);

            imageView.setX(50);
            imageView.setY(25);

            imageView.setFitHeight(455);
            imageView.setFitWidth(500);

            imageView.setPreserveRatio(true);

            Group root = new Group(imageView);

            Scene scene = new Scene(root, 600, 500);

            stage.setTitle("Drawing an image");
            stage.setScene(scene);
            stage.show();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }

    private void drawForm(Stage stage){
        Text nameLabel = new Text("Name");

        TextField nameText = new TextField();

        Text doLabel = new Text("Date of birth");

        DatePicker datePicker = new DatePicker();

        Text genderLabel = new Text("Gender");

        ToggleGroup groupGender = new ToggleGroup();
        RadioButton maleRadio = new RadioButton("male");
        maleRadio.setToggleGroup(groupGender);
        RadioButton femaleRadio = new RadioButton("female");
        femaleRadio.setToggleGroup(groupGender);

        Text reservationLabel = new Text("Reservation");

        ToggleButton Reservation = new ToggleButton();
        ToggleButton yes = new ToggleButton("Yes");
        ToggleButton no = new ToggleButton("No");
        ToggleGroup groupReservation = new ToggleGroup();
        yes.setToggleGroup(groupReservation);
        no.setToggleGroup(groupReservation);

        Text technologiesLabel = new Text("Technologies Known");

        CheckBox javaCheckBox = new CheckBox("Java");

        CheckBox dotnetCheckBox = new CheckBox("DotNet");

        Text educationLabel = new Text("Educational qualification");

        ObservableList<String> names = FXCollections.observableArrayList("Engineering", "MTECH", "Mphil", "Phd");
        ListView<String> educationListView = new ListView<String>(names);

        Text locationLabel = new Text("Location");

        ChoiceBox locationChoiceBox = new ChoiceBox();
        locationChoiceBox.getItems().addAll("Hyderabad", "Chennai", "Delhi", "Dubai");

        Button buttonRegister = new Button("Register");

        GridPane gridPane = new GridPane();
        gridPane.setMinSize(500, 500);
        gridPane.setPadding(new Insets(10, 10, 10, 10));

        gridPane.setVgap(5);
        gridPane.setHgap(5);
        gridPane.setAlignment(Pos.CENTER);

        gridPane.add(nameLabel, 0, 0);
        gridPane.add(nameText, 1, 0);
        gridPane.add(doLabel, 0, 1);
        gridPane.add(datePicker, 1, 1);
        gridPane.add(genderLabel, 0, 2);
        gridPane.add(maleRadio, 1, 2);
        gridPane.add(femaleRadio, 2, 2);
        gridPane.add(reservationLabel, 0, 3);
        gridPane.add(yes, 1, 3);
        gridPane.add(no, 2, 3);
        gridPane.add(technologiesLabel, 0, 4);
        gridPane.add(javaCheckBox, 1, 4);
        gridPane.add(dotnetCheckBox, 2, 4);
        gridPane.add(educationLabel, 0, 5);
        gridPane.add(educationListView, 1, 5);
        gridPane.add(locationLabel, 0, 6);
        gridPane.add(locationChoiceBox, 1, 6);
        gridPane.add(buttonRegister, 2, 8);

        nameLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        doLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        genderLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        reservationLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        technologiesLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        educationLabel.setStyle("-fx-font: normal bold 15px 'serif' ");
        locationLabel.setStyle("-fx-font: normal bold 15px 'serif' ");

        gridPane.setStyle("-fx-background-color: BEIGE;");

        Scene scene = new Scene(gridPane);

        Text wellDone = new Text("Well done");
        wellDone.setX(50);
        wellDone.setY(50);
        wellDone.setStyle("-fx-font: normal bold 15px 'serif' ");
        Pane succesPane = new Pane();
        succesPane.getChildren().add(wellDone);

        Scene scene2 = new Scene(succesPane, 200, 200);

        stage.setTitle("Registration form");

        buttonRegister.addEventHandler(ActionEvent.ACTION, event -> stage.setScene(scene2));

        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
