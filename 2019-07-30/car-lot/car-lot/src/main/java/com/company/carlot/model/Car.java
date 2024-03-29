package com.company.carlot.model;

import javax.validation.constraints.NotEmpty;
import javax.validation.constraints.Size;
import java.util.Objects;

public class Car {

    private int id;
    @NotEmpty(message = "You must supply a value for make.")
    private String make;
    @NotEmpty(message = "You must supply a value for model.")
    private String model;
    @NotEmpty(message = "You must supply a value for year.")
    @Size(min = 4, max = 4, message = "Year must be 4 digits.")
    private String year;
    @NotEmpty(message = "You must supply a value for color.")
    private String color;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }


    public String getMake() {
        return make;
    }

    public void setMake(String make) {
        this.make = make;
    }

    public String getYear() {
        return year;
    }

    public void setYear(String year) {
        this.year = year;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Car that = (Car) o;
        return getId() == that.getId() &&
                Objects.equals(getMake(), that.getMake()) &&
                Objects.equals(getModel(), that.getModel()) &&
                Objects.equals(getYear(), that.getYear()) &&
                Objects.equals(getColor(), that.getColor());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getId(), getMake(), getModel(), getYear(), getColor());
    }
}

