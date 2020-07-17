export interface ICrud {

    editMode: boolean;
    isModified: boolean;

    //#region Crud Methos
    create();
    read();
    update(obj);
    delete(obj);
    //#endregion

    cancel();
    save(obj);

}

export interface IEditableViewModel {
    edit: boolean;
    id: string;
  }