import { Request, Response } from 'express';
import { Funcionario } from '../models/Funcionario';
import { Loja } from '../models/Loja';
import { Ong } from '../models/Ong';
import { Voluntario } from '../models/Voluntario';
import { Contato } from '../models/Contatos';

import {sequelize } from '../instances/mysql'

export const home = async (req:Request, res:Response) => {
    try{
        await sequelize.authenticate()
        console.log("Conexão estabilizada com sucesso!")
    } catch(error){
        console.log("Deu problema: ",error)
    }
    
    res.render('pages/home')
}
export const perfil = (req:Request, res:Response) =>{
    res.render('pages/perfil')
}
export const sobre = (req:Request, res:Response) =>{
    res.render('pages/sobre')
}
export const vagas = (req:Request, res:Response) =>{
    res.render('pages/vagas')
}
export const loja = (req:Request, res:Response) =>{
    res.render('pages/loja')
}
export const contato = (req:Request, res:Response) =>{
    res.render('pages/contato')
}
export const vaga =(req:Request, res:Response)=>{
    res.render('pages/vaga')
}
export const confirmCad = (req:Request, res:Response) =>{
    res.render('pages/confirmCad')
}
export const cadFinalizado = (req:Request, res:Response) =>{
    res.render('pages/cadFinalizado')
}