import React from 'react'
import { testIncomeStatementData } from './testData'

const data=testIncomeStatementData;

type Props={
    config:any;
    data:any;
};
type Company=(typeof data)[0];


const Table = ({config,data}: Props) => {
    const renderedRow=data.map((company:any) =>
    {
        return (
            <tr key={company.cik}>
                {config.map((val:any)=> 
                {
                    return (<td className='p-4 whitespace-nowrap text-sm font-normal text-gray-900'>
                        {val.render(company)}
                        </td>)
                })}
                
            </tr>
        )

    });
    const renderedHeaders=config.map((config: any) => 
    {
        return(<th className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider" key={config.label}>{config.label}</th>)
    });
  return (
    <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8 ">
        <table>
            <thead className='min-w-full divide-y divide-gray-200 m-5'>{renderedHeaders}</thead>
            <tbody>{renderedRow}</tbody>
        </table>
    </div>
  )
}

export default Table