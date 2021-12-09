package entity;

import javax.persistence.*;

@Entity
@Table(name = "Worker")
public class Worker {
    @Id
    @Column(name = "idWorker")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idWorker;

    @Column(nullable = false)
    private String name;

    @Column(nullable = false)
    private String lastname;

    @Column(nullable = false)
    private int idFirm;

    @ManyToOne
    @JoinColumn(name = "idFirm", nullable = false, insertable = false, updatable = false)
    private Firm firm;

    public Worker(String name, String lastname, int idFirm) {
        this.name = name;
        this.lastname = lastname;
        this.idFirm = idFirm;
    }

    public Worker(){}

    public int getIdWorker() {
        return idWorker;
    }

    public void setIdWorker(int idWorker) {
        this.idWorker = idWorker;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getLastname() {
        return lastname;
    }

    public void setLastname(String lastname) {
        this.lastname = lastname;
    }

    public int getIdFirm() {
        return idFirm;
    }

    public void setIdFirm(int idFirm) {
        this.idFirm = idFirm;
    }

    public Firm getFirm() {
        return firm;
    }

    public void setFirm(Firm firm) {
        this.firm = firm;
    }

    @Override
    public String toString() {
        return "Worker{" +
                "idWorker=" + idWorker +
                ", name='" + name + '\'' +
                ", lastname='" + lastname + '\'' +
                ", firm='" + firm + '\'' +
                '}';
    }
}
