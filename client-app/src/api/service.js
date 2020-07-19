import requests from './axiosConfig';

function getAuthHeader() {
    var currentUser = JSON.parse(localStorage.getItem('user'));
    return { 'Authorization': 'Bearer ' + currentUser.token };
}

export const Listings = {
    getListingsForLP: (params) =>
        requests.get('Listing/GetListingsForLP', params),
    getListingFormData: (id) =>
        requests.get(`Listing/GetListingFormData?id=${id}`),
    addListing: (data) =>
        requests.post(`Listing`, data, {
            'Content-Type': 'multipart/form-data',
            ...getAuthHeader(),
        }),
};

export const Account = {
    register: (body) => requests.post('Account/Register', body),
    login: (body) => requests.post(`Account/Login`, body),
};

export const Mapbox = {
    searchAddress: (searchText) =>
        requests.get(
            `https://api.mapbox.com/geocoding/v5/mapbox.places/${encodeURIComponent(
                searchText
            )}.json`,
            {
                access_token: process.env.REACT_APP_MAPBOX_API_KEY,
                autocomplete: true,
                country: 'cz',
                types: 'address',
            }
        ),
};
