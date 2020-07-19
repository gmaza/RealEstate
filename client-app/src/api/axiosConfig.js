import axios from 'axios';

const ax = axios.create();

ax.defaults.baseURL = 'https://localhost:44399/api';

//interceptors
let counter = 0;

const count = (val) => {
    counter += val;
    const loader = document.getElementById('loader');

    if (loader) {
        if (counter > 0) {
            loader.style.display = 'flex';
        } else {
            loader.style.display = 'none';
        }
    }
};

ax.interceptors.request.use(
    function (config) {
        count(1);
        return config;
    },
    function (error) {
        count(-1);
        return Promise.reject(error);
    }
);

ax.interceptors.response.use(
    function (response) {
        count(-1);
        return response;
    },
    function (error) {
        count(-1);
        return Promise.reject(error);
    }
);

//request config

const responseBody = (response) => response.data;

export default {
    get: (url, params) =>
        ax
            .get(url, {
                params: params,
            })
            .then(responseBody),
    post: (url, body, headers = {}) =>
        ax.post(url, body, { headers: headers }).then(responseBody),
    put: (url, body) => ax.put(url, body).then(responseBody),
    del: (url) => ax.delete(url).then(responseBody),
};
