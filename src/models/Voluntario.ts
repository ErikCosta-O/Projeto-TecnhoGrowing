import { Model,DataTypes } from "sequelize"

import {sequelize} from '../instances/mysql'


export interface VoluntarioInstance extends Model{
    id: number,
    nome: string,
    dataNascimento: Date,
    email: string,
    password: string,
    cpf: number,
    telefone: number,
    experiencia: String,
    URL: String,
}

export const Voluntario = sequelize.define<VoluntarioInstance>("Voluntario,",{
    id: {
        type:DataTypes.INTEGER,
        primaryKey:true,
        autoIncrement:true
    },
    nome:{
        type: DataTypes.STRING,
        allowNull:false
    }, 
    dataNascimento:{     
        type: DataTypes.DATE,
        allowNull:false
    }, 
    email:{     
        type: DataTypes.STRING,
        allowNull:false
    },    
    password:{
        type: DataTypes.STRING,
        allowNull:false
    },
    cpf:{
        type: DataTypes.NUMBER,
        allowNull:false
    },
    tel:{
        type: DataTypes.NUMBER,
        allowNull:false
    },
    experiencia:{
        type: DataTypes.STRING,
        allowNull:false
    },
    redeSocial:{
        type: DataTypes.STRING,
        allowNull:false
    },
    URL:{
        type: DataTypes.STRING,
        allowNull:false
    }
},
{
    tableName: "tbVoluntario",
    timestamps:false
})