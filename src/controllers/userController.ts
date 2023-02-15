import { Request, Response } from 'express';
import { Voluntario } from '../models/Voluntario';

export const contaUsuario = (req:Request, res:Response) =>{
    res.render('pages/ContaUsuario')
}

// export const login = (req:Request, res:Response) => {
//     res.render('pages/login')
// }