import { Request, Response } from 'express';
import { Ong } from '../models/Ong';

export const contaOng = (req:Request, res:Response) =>{
    res.render('pages/ContaOng')
}
export const criarVaga = (req:Request, res:Response) =>{
    res.render('pages/criarVaga')
}
// export const login = (req:Request, res:Response) => {
//     res.render('pages/login')
// }