import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { ICrud } from '../services/interfaces'
import { Doctor, DoctorService } from '../services/doctor/doctor.service'

@Component({
  selector: 'app-doctor',
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']
})
export class DoctorComponent implements OnInit, ICrud {
  doctors: Doctor[];
  editMode: boolean = false;
  isModified: boolean = false;

  private itemSelecionado = {} as Doctor;

  constructor(private service: DoctorService) { }

  ngOnInit() {
    this.read();
  }

  public create() {
    this.doctors.unshift({ edit: true } as Doctor)
    this.editMode = true;
  }

  public read() {
    this.service.getDoctors().subscribe(result => this.doctors = result);
  }

  public update(obj) {
    this.itemSelecionado = obj;
    this.itemSelecionado.edit = true;
    this.isModified = true;
    this.editMode = true;
  }

  public cancel() {
    if (!this.isModified)
      this.doctors.shift();
    this.itemSelecionado.edit = false;
    this.editMode = false;
    this.isModified = false;
  }

  public save(obj) {
    this.itemSelecionado = obj;
    this.itemSelecionado.edit = false;
    this.editMode = false;
    this.isModified = false;
  }

  public delete(obj) {
    //com um pouco mais de trabalho eu criaria um componente de mensagens ou usuário um de algum framework
    if (confirm("Deseja realmente excluir o médico?")) {
      alert("médico excluído");
    }
  }

}






