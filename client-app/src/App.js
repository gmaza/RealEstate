import React, { useState, useEffect } from 'react';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import logo from './logo.svg';
import './App.css';
import { Navbar } from './components/navbar';
import { Home } from './views/home';
import { LoadingContainer, Spinner } from './components/loader';
import {
    Container,
    CssBaseline,
    CircularProgress,
    createMuiTheme,
} from '@material-ui/core';
import { StylesProvider, MuiThemeProvider } from '@material-ui/core/styles';
import { AddListing } from './views/addListing';
import { Search } from './views/search';
import { AuthContext } from './contexts/authContext';

const currentUser = JSON.parse(localStorage.getItem('user'));

function App() {
    const [user, setUser] = useState(currentUser);

    useEffect(() => {
        localStorage.setItem('user', JSON.stringify(user));
    }, [user]);

    const defaultTheme = createMuiTheme({
        transitions: {
            create: () => 'none',
        },
        props: {
            MuiButtonBase: {
                disableRipple: true,
            },
        },
        palette: {
            primary: {
                main: '#D9E4FF',
            },
            secondary: {
                main: '#004DFF',
            },
        },
        spacing: 8,
        typography: {
            h1: {
                fontFamily: 'Roboto',
                fontStyle: 'normal',
                fontWeight: 'bold',
                fontSize: '30px',
                lineHeight: '36px',

                textAlign: 'center',

                color: '#404040',
            },
            subtitle1: {
                fontFamily: 'Roboto',
                fontStyle: 'normal',
                fontWeight: '300',
                fontSize: '14px',
                lineHeight: '19px',

                textAlign: 'center',

                color: '#404040',
            },
        },
    });

    return (
        <AuthContext.Provider value={{ user, setUser }}>
            <StylesProvider injectFirst>
                <MuiThemeProvider theme={defaultTheme}>
                    <Router>
                        <div>
                            <Navbar />
                            <div style={{ marginTop: '60px' }}>
                                <Switch>
                                    <Route exact path="/">
                                        <Home />
                                    </Route>
                                    <Route exact path="/search">
                                        <Search />
                                    </Route>
                                    <Route exact path="/addListing">
                                        <AddListing />
                                    </Route>
                                </Switch>
                            </div>
                        </div>
                        <LoadingContainer id="loader">
                            <Spinner />
                        </LoadingContainer>
                    </Router>
                </MuiThemeProvider>
            </StylesProvider>
        </AuthContext.Provider>
    );
}

export default App;
