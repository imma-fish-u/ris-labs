package model;

import entity.Firm;
import entity.Worker;

import javax.enterprise.context.ApplicationScoped;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

@ApplicationScoped
public class Model {
    private Statement statement;
    private Connection connection;
    private EntityManager entityManager;

    public Model() {
        EntityManagerFactory emf = Persistence.createEntityManagerFactory("PersistenceUnit");
        entityManager = emf.createEntityManager();

        try {
           connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/work?useUnicode=true&serverTimezone=UTC", "root", "1964");
           statement = connection.createStatement();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public List<Worker> getAllWorkers() {
        ArrayList<Worker> workers = new ArrayList<>();
        try {
            ResultSet resultSet = statement.executeQuery("SELECT * FROM worker");
            while (resultSet.next()) {
                workers.add(new Worker(resultSet.getString("name"), resultSet.getString("lastname"), resultSet.getInt("idFirm")));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return workers;
    }

    public List<Firm> getAllFirms() {
        ArrayList<Firm> firms = new ArrayList<>();
        try {
            ResultSet resultSet = statement.executeQuery("SELECT * FROM firm");
            while (resultSet.next()) {
                firms.add(new Firm(resultSet.getString("nameFirm")));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return firms;
    }

    public ArrayList<Worker> findWorkers(String name, String lastname) {
        ArrayList<Worker> workers = new ArrayList<>();
        try {
            ResultSet resultSet = statement.executeQuery("SELECT * FROM worker WHERE name='" + name + "' AND lastname='" + lastname + "'");
            while (resultSet.next()) {
                workers.add(new Worker(resultSet.getString("name"), resultSet.getString("lastname"), resultSet.getInt("idFirm")));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return workers;
    }

    public void addFirm(Firm firm) {
        entityManager.getTransaction().begin();

        entityManager.persist(firm);

        entityManager.getTransaction().commit();
    }

    public void addWorker(Worker worker) {
        entityManager.getTransaction().begin();

        entityManager.persist(worker);

        entityManager.getTransaction().commit();
    }

    public void deleteFirm(Firm firm) {
        entityManager.getTransaction().begin();

        entityManager.createQuery("DELETE FROM Worker WHERE idFirm=" + firm.getIdFirm()).executeUpdate();

        entityManager.remove(entityManager.contains(firm) ? firm : entityManager.merge(firm));

        entityManager.getTransaction().commit();
    }

}
