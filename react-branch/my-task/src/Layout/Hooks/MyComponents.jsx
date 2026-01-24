import React, { useState, useEffect } from "react";
import axios from 'axios';

const MyComponents = () => {
    const [count, setCount] = useState(0);
    const baseUrl = `https://jsonplaceholder.typicode.com/posts`;

    const temp = axios.get(baseUrl).then(response => {
        console.log(response.data.slice(0,5));
    })



    useEffect(() => {
        document.title = `Значение ${temp}`;
    })

    return (
        <div>
            
            <button onClick={() => {setCount(count+1)}}>
                Жми меня
            </button>
        </div>
    );
};

export default MyComponents;