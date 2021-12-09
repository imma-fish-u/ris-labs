package net.proselyte.workmanager.model;

import javax.persistence.*;

@Entity
@Table(name = "Worker")
public class Worker {
    @Id
    @Column(name = "idWorker")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idWorker;
    private String name;
    private String lastname;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "idFirm")
    private Firm firm;

    public int getIdWorker() {
        return idWorker;
    }
    public void setIdWorker(int idWorker) { this.idWorker = idWorker; }
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public String getLastname() { return lastname; }
    public void setLastname(String lastname) { this.lastname = lastname; }

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
