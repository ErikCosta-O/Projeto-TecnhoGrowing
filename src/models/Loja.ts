import { Model, DataTypes } from "sequelize";

import { sequelize } from '../instances/mysql';

export interface lojaInstance extends Model {
    codLoja: number,
    produtos: String,
    valor: number,
    quantidade: number,
    descricao: String,
    codFunc: number
}

export const Loja = sequelize.define<lojaInstance>("Loja,",{
    codLoja:{
        primaryKey:true,
        type:DataTypes.INTEGER
    },
    produtos:{
        type:DataTypes.STRING
    },
    valor:{
        type:DataTypes.FLOAT
    },
    quantidade:{
        type:DataTypes.INTEGER
    },
    descricao:{
        type:DataTypes.STRING
    },
    codFunc:{
        type:DataTypes.INTEGER
    }
},
{
    tableName:"tbLoja",
    timestamps: false
})