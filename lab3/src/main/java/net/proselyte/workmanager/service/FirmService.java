package net.proselyte.workmanager.service;

import net.proselyte.workmanager.model.Firm;

import java.util.List;

public interface FirmService {
    public void addFirm(Firm firm);
    public void updateFirm(Firm firm);
    public void removeFirm(int idFirm);
    public Firm getFirmById(int idFirm);
    public List<Firm> listFirms();
}
