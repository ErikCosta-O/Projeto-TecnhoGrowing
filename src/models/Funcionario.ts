import { Model , DataTypes } from "sequelize";

import {sequelize} from '../instances/mysql'

export interface FuncionarioInstance extends Model {

    codFunc: number,
    nome: String,
    cpf: String,
    dataNascimento: Date,
    registroFunc: string,
    CTPS: string,
    serie: string,
    telefone: number,
    email: String,
    numero: string,
    complemento: string,
    cep: string,
    bairro: string,
    cidade: string,
    cargo: String,
}

export const Funcionario = sequelize.define<FuncionarioInstance>("Funcionario,",{
    codFunc:{
        primaryKey:true,
        type:DataTypes.INTEGER,
        allowNull:false
    },
    nome:{
        type:DataTypes.DATE,
        allowNull:false
    },
    dataNascimento:{
        type:DataTypes.STRING,
        allowNull:false
    },
    registro:{
        type:DataTypes.STRING,
        allowNull:false
    },
    CTPS:{
        type:DataTypes.STRING,
        allowNull:false
    },
    serie:{
        type:DataTypes.STRING,
        allowNull:false
    },
    cpf:{
        type:DataTypes.STRING,
        allowNull:false
    },
    telefone:{
        type:DataTypes.STRING,
        allowNull:false
    },
    email:{
        type:DataTypes.STRING,
        allowNull:false
    },
    cep:{
        type:DataTypes.STRING,
        allowNull:false
    },
    bairro:{
        type:DataTypes.STRING,
        allowNull:false
    },
    cidade:{
        type:DataTypes.STRING,
        allowNull:false
    },
    complemento:{
        type:DataTypes.STRING,
        allowNull:false
    },
    cargo:{
        type:DataTypes.STRING,
        allowNull:false
    }
},{
    tableName:'tbFuncionario',
    timestamps:false
}
)