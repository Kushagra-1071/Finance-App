import React, { useEffect, useState } from 'react'
import { CompanyCompData } from '../../company';
import { getCompData } from '../../api';
import CompFinderitem from './CompFinderitem';

type Props = {
    ticker:string;
}

const CompFinder = ({ticker}: Props) => {
    const [companyData,SetCompanyData]=useState<CompanyCompData>();
    useEffect(()=>{
        const getComps=async() =>
            {
                const value=await getCompData(ticker);
                SetCompanyData(value?.data[0]);
            }
            getComps();
    },[ticker]);
  return (
    <div className='inline-flex rounded-md shadow-sm m-4'>{companyData?.peersList.map((ticker)=> 
    {
        return <CompFinderitem ticker={ticker}/>
    })}</div>
  )
}

export default CompFinder