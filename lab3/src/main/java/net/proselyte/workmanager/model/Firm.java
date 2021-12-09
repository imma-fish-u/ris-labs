package net.proselyte.workmanager.model;

import javax.persistence.*;
import java.util.List;
import java.util.Set;


@Entity
@Table(name = "firm")
public class Firm {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idFirm;

    private String nameFirm;

    @OneToMany(mappedBy = "firm", cascade = CascadeType.ALL, orphanRemoval = true)
    private Set<Worker> workers;

    public Firm() { }

    public int getIdFirm() {
        return idFirm;
    }

    public void setIdFirm(int idFirm) {
        this.idFirm = idFirm;
    }

    public String getNameFirm() {
        return nameFirm;
    }

    public void setNameFirm(String nameFirm) {
        this.nameFirm = nameFirm;
    }

    @Override
    public String toString() {
        return "Firm{" +
                "idFirm=" + idFirm +
                ", nameFirm='" + nameFirm + '\'' +
                '}';
    }
}

