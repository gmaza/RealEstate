import styled from 'styled-components';
import { FlexRow } from '../globals';
import { Button } from '@material-ui/core';
import searchBackground from '../../assets/search-background.png';

export const AreaInputsContainer = styled(FlexRow)`
    margin-top: 10px;
    > * {
        flex: 1;
    }

    > :first-child {
        margin-right: 10px;
    }
`;

export const FilterButton = styled(Button)`
    background-color: #d9e4ff;
    border-radius: 5px;
    width: 56px;
    height: 56px;
    margin-left: 10px;

    &:hover {
        background-color: #d9e4ff;
    }

    .MuiSvgIcon-root {
        font-size: 1.5rem;
    }
`;

export const AdvanceSearchContainer = styled.div`
    padding: 0 16px;
    background: #fff;
    z-index: 10;
    overflow: hidden;
    transition: all 0.4s ease-out;
`;

export const SearchBarWrapper = styled.div`
    background: ${(props) =>
        props.withBackground ? `url(${searchBackground})` : '#ffffff'};
    background-size: cover;
    padding-top: 1px;
    padding: 15px 0;

    @media (min-width: 992px) {
        height: ${(props) => (props.withBackground ? '300px' : 'auto')};
        padding: 20px 0;
    }

    #search-container {
        @media (min-width: 992px) {
            ${(props) =>
                props.withBackground
                    ? `padding: 40px;
                background: #FFFFFF;
                box-shadow: 0px 6px 10px rgba(0, 0, 0, 0.12);
                border-radius: 10px;`
                    : ''}
        }
    }
`;

export const SearchTitle = styled.h1`
    font-family: Roboto;
    font-style: normal;
    font-weight: bold;
    font-size: 30px;
    text-align: center;
    line-height: 120%;
    color: #404040;

    span {
        color: #004dff;
    }
`;
