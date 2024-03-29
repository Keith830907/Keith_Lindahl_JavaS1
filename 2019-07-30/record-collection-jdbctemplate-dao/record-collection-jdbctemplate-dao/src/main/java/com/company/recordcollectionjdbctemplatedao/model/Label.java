package com.company.recordcollectionjdbctemplatedao.model;

import java.util.Objects;

public class Label {

    private int id;
    private String name;
    private String website;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getWebsite() {
        return website;
    }

    public void setWebsite(String website) {
        this.website = website;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Label label = (Label) o;
        return Objects.equals(getName(), label.getName()) &&
                Objects.equals(getWebsite(), label.getWebsite());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getName(), getWebsite());
    }
}

