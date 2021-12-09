package net.proselyte.workmanager.dao;

import net.proselyte.workmanager.model.Firm;

import java.util.List;

public interface FirmDao {
    public void addFirm(Firm firm);

    public void updateFirm(Firm firm);

    public void removeFirm(int idFirm);

    public Firm getFirmById(int idFirm);

    public List<Firm> listFirms();
}
